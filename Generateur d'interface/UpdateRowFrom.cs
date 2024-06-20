using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Generateur_d_interface
{
    public partial class UpdateRowForm : Form
    {
        private string _connectionString;
        private string _tableName;
        private DataRow _row;

        public UpdateRowForm(string connectionString, string tableName, DataRow row)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _tableName = tableName;
            _row = row;

            LoadRowData();
        }

        private void LoadRowData()
        {
            foreach (DataColumn column in _row.Table.Columns)
            {
                Label label = new Label
                {
                    Text = column.ColumnName,
                    Location = new Point(50, 50 + (50 * (flowLayoutPanel1.Controls.Count / 2))),
                    AutoSize = true
                };
                TextBox textBox = new TextBox
                {
                    Name = column.ColumnName,
                    Text = _row[column].ToString(),
                    Location = new Point(200, 50 + (50 * (flowLayoutPanel1.Controls.Count / 2))),
                    Size = new Size(150, 20)
                };

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(textBox);
            }

            /*Button updateButton = new Button
            {
                Text = "Uppdate",
                AutoSize = true,
                Location = new Point(200, 50 + (50 * (flowLayoutPanel1.Controls.Count / 2)))
            };
            updateButton.Click += UpdateButton_Click;

            flowLayoutPanel1.Controls.Add(updateButton);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            OpsTablesForm opsTablesForm = new OpsTablesForm(_connectionString);
            opsTablesForm.ShowDialog();
            // Close the OpsTablesForm after AddRowToTableForm is closed
            this.Close();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string updateQuery = $"UPDATE {_tableName} SET ";
                List<string> setClauses = new List<string>();

                // Clear previous parameters to avoid duplication
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        string columnName = textBox.Name;
                        string columnValue = textBox.Text;

                        if (columnName != "id") // Assuming 'id' is the primary key and should not be updated
                        {
                            setClauses.Add($"{columnName} = @{columnName}");
                            cmd.Parameters.AddWithValue($"@{columnName}", columnValue);
                        }
                    }
                }

                updateQuery += string.Join(", ", setClauses) + " WHERE id = @id";
                cmd.CommandText = updateQuery;

                // Add the id parameter only once
                cmd.Parameters.AddWithValue("@id", _row["id"]);

                cmd.ExecuteNonQuery();

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
