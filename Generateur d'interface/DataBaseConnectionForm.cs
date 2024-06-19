using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Generateur_d_interface
{
    public partial class DataBaseConnectionForm : Form
    {
        public DataBaseConnectionForm()
        {
            InitializeComponent();
        }

        private void DataBaseConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void ConnectDB_Click(object sender, EventArgs e)
        {
            string host = HostDB.Text;
            string username = UsernameDB.Text;
            string password = PasswordDB.Text;
            string database = DatabaseName.Text;

            string connectionString = $"Server={host};Database={database};Uid={username};Pwd={password};";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to OpsTablesForm and pass the connection string
                    OpsTablesForm opsTablesForm = new OpsTablesForm(connectionString);
                    this.Hide(); // Hide the current form
                    opsTablesForm.ShowDialog(); // Show the OpsTablesForm
                    this.Close(); // Close the current form after the OpsTablesForm is closed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
