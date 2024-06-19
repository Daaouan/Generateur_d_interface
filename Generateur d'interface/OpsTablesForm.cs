using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Generateur_d_interface
{
    public partial class OpsTablesForm : Form
    {
        private string _connectionString;

        public OpsTablesForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void OpsTablesForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    // Get the list of tables
                    MySqlCommand cmd = new MySqlCommand("SHOW TABLES;", connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[0].ToString());
                    }
                    reader.Close();

                    comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

                    // Set initial state of button1
                    button1.Enabled = comboBox1.SelectedIndex != -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tableName))
            {
                LoadTableData(tableName);
                button1.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                button1.Enabled = false;
            }
        }

        private void LoadTableData(string tableName)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Filter out empty rows
                dataTable = dataTable.AsEnumerable()
                                     .Where(row => !row.ItemArray.All(field => field is DBNull || string.IsNullOrEmpty(field.ToString())))
                                     .CopyToDataTable();

                dataGridView1.DataSource = dataTable;

                // Add update button column if not already added
                if (!dataGridView1.Columns.Contains("Update"))
                {
                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Update",
                        Text = "Update",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridView1.Columns.Add(updateButtonColumn);
                }

                // Add delete button column if not already added
                if (!dataGridView1.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridView1.Columns.Add(deleteButtonColumn);
                }

                // Move the update and delete columns to the end
                dataGridView1.Columns["Update"].DisplayIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns["Delete"].DisplayIndex = dataGridView1.Columns.Count - 1;

                dataGridView1.CellClick += DataGridView1_CellClick;
            }
        }

  /*      private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    MessageBox.Show($"Update row with ID {id}");
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    MessageBox.Show($"Delete row with ID {id}");
                }
            }
        }
  */
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    string tableName = comboBox1.SelectedItem.ToString();
                    DataRow row = ((DataTable)dataGridView1.DataSource).Rows[e.RowIndex];
                    UpdateRow(tableName, row);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    string tableName = comboBox1.SelectedItem.ToString();
                    DeleteRow(tableName, id);
                }
            }
        }

        private void UpdateRow(string tableName, DataRow row)
        {
            using (UpdateRowForm updateForm = new UpdateRowForm(_connectionString, tableName, row))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTableData(tableName); // Refresh the data grid view
                }
            }
        }
        private void DeleteRow(string tableName, int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM {tableName} WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadTableData(tableName); // Refresh the data grid view
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTable))
            {
                this.Hide(); // Hide the current form
                AddRowToTableForm addRowForm = new AddRowToTableForm(_connectionString, selectedTable);
                // Close the OpsTablesForm after AddRowToTableForm is closed
                this.Close();
                addRowForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Please select a table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
