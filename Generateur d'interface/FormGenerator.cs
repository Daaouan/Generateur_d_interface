using System;
using System.Data;
using System.Windows.Forms;

namespace Generateur_d_interface
{
    public class FormGenerator
    {
        private SchemaReader _schemaReader;

        public FormGenerator(SchemaReader schemaReader)
        {
            _schemaReader = schemaReader;
        }

        public Form GenerateForm(string tableName)
        {
            Form form = new Form();
            DataTable columns = _schemaReader.GetColumns(tableName);
            int yPosition = 10;

            foreach (DataRow column in columns.Rows)
            {
                string columnName = column["COLUMN_NAME"].ToString();
                string dataType = column["DATA_TYPE"].ToString();

                Label label = new Label
                {
                    Text = columnName,
                    Location = new System.Drawing.Point(10, yPosition)
                };
                form.Controls.Add(label);

                Control inputControl;

                switch (dataType)
                {
                    case "int":
                        inputControl = new TextBox
                        {
                            Name = columnName,
                            Location = new System.Drawing.Point(120, yPosition)
                        };
                        break;
                    case "nvarchar":
                    case "varchar":
                        inputControl = new TextBox
                        {
                            Name = columnName,
                            Location = new System.Drawing.Point(120, yPosition)
                        };
                        break;
                    // Add cases for other data types and custom controls as needed
                    default:
                        inputControl = new TextBox
                        {
                            Name = columnName,
                            Location = new System.Drawing.Point(120, yPosition)
                        };
                        break;
                }

                form.Controls.Add(inputControl);
                yPosition += 30;
            }

            return form;
        }
    }
}
