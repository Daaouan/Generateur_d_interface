using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur_d_interface
{
    public class DataMapper
    {
        public static void MapDataToControls(Control parent, DataRow dataRow)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    string columnName = textBox.Name;
                    textBox.Text = dataRow[columnName].ToString();
                }
                // Add mapping for other control types as needed
            }
        }

        public static void MapControlsToData(Control parent, DataRow dataRow)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    string columnName = textBox.Name;
                    dataRow[columnName] = textBox.Text;
                }
                // Add mapping for other control types as needed
            }
        }
    }

}
