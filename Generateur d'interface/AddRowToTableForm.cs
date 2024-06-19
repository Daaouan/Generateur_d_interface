using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Generateur_d_interface
{
    public partial class AddRowToTableForm : Form
    {
        private string _connectionString;
        private string _defaultTable;

        public AddRowToTableForm(string connectionString, string defaultTable = null)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _defaultTable = defaultTable;
        }

        private void AddRowToTableForm_Load(object sender, EventArgs e)
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

                    // Select the default table if it exists
                    if (!string.IsNullOrEmpty(_defaultTable) && comboBox1.Items.Contains(_defaultTable))
                    {
                        // Ensure SelectedIndexChanged event is wired up before setting default
                        comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                        comboBox1.SelectedItem = _defaultTable;
                    }
                    else
                    {
                        // For example, show a message or set a default selection
                        comboBox1.SelectedIndex = 0; // Select the first item as default if _defaultTable is not found
                    }
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
                // Retrieve table schema
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = $"SHOW COLUMNS FROM {tableName};";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string columnName = reader["Field"].ToString();
                        string columnType = reader["Type"].ToString(); // You can use this for control creation
                                                                       // Create form controls based on columnType (e.g., textbox for VARCHAR, numeric up/down for INT, etc.)
                                                                       // For simplicity, let's add textboxes for each column
                        Label label = new Label
                        {
                            Text = columnName,
                            Location = new Point(50, 50 + (50 * (flowLayoutPanel1.Controls.Count / 2))),
                            AutoSize = true
                        };
                        TextBox textBox = new TextBox
                        {
                            Name = columnName,
                            Location = new Point(200, 50 + (50 * (flowLayoutPanel1.Controls.Count / 2))),
                            Size = new Size(150, 20)
                        };
                        flowLayoutPanel1.Controls.Add(label);
                        flowLayoutPanel1.Controls.Add(textBox);
                    }
                    reader.Close();
                }
            }
        }



        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tableName))
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO {tableName} (", connection);
                    List<string> columns = new List<string>();
                    List<string> values = new List<string>();

                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control is TextBox)
                        {
                            columns.Add(control.Name);
                            values.Add($"'{(control as TextBox).Text}'");
                        }
                        // Add more cases for different control types (e.g., numeric up/down)
                    }

                    cmd.CommandText += string.Join(", ", columns) + ") VALUES (" + string.Join(", ", values) + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully.");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            OpsTablesForm opsTablesForm = new OpsTablesForm(_connectionString);
            opsTablesForm.ShowDialog();
            // Close the OpsTablesForm after AddRowToTableForm is closed
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
