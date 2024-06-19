namespace Generateur_d_interface
{
    partial class DataBaseConnectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.HostDB = new System.Windows.Forms.TextBox();
            this.UsernameDB = new System.Windows.Forms.TextBox();
            this.PasswordDB = new System.Windows.Forms.TextBox();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostDB
            // 
            this.HostDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.HostDB.Location = new System.Drawing.Point(215, 75);
            this.HostDB.Multiline = true;
            this.HostDB.Name = "HostDB";
            this.HostDB.Size = new System.Drawing.Size(258, 30);
            this.HostDB.TabIndex = 0;
            // 
            // UsernameDB
            // 
            this.UsernameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UsernameDB.Location = new System.Drawing.Point(215, 124);
            this.UsernameDB.Multiline = true;
            this.UsernameDB.Name = "UsernameDB";
            this.UsernameDB.Size = new System.Drawing.Size(258, 30);
            this.UsernameDB.TabIndex = 1;
            // 
            // PasswordDB
            // 
            this.PasswordDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PasswordDB.Location = new System.Drawing.Point(215, 172);
            this.PasswordDB.Multiline = true;
            this.PasswordDB.Name = "PasswordDB";
            this.PasswordDB.Size = new System.Drawing.Size(258, 30);
            this.PasswordDB.TabIndex = 2;
            this.PasswordDB.UseSystemPasswordChar = true;
            // 
            // DatabaseName
            // 
            this.DatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DatabaseName.Location = new System.Drawing.Point(215, 228);
            this.DatabaseName.Multiline = true;
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(258, 30);
            this.DatabaseName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label2.Location = new System.Drawing.Point(49, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label4.Location = new System.Drawing.Point(49, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database:";
            // 
            // ConnectDB
            // 
            this.ConnectDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ConnectDB.Location = new System.Drawing.Point(265, 300);
            this.ConnectDB.Name = "ConnectDB";
            this.ConnectDB.Size = new System.Drawing.Size(123, 45);
            this.ConnectDB.TabIndex = 8;
            this.ConnectDB.Text = "Connect";
            this.ConnectDB.UseVisualStyleBackColor = true;
            this.ConnectDB.Click += new System.EventHandler(this.ConnectDB_Click);
            // 
            // DataBaseConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.ConnectDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.PasswordDB);
            this.Controls.Add(this.UsernameDB);
            this.Controls.Add(this.HostDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(542, 489);
            this.MinimumSize = new System.Drawing.Size(542, 489);
            this.Name = "DataBaseConnectionForm";
            this.Text = "UIGen - Database Connection";
            this.Load += new System.EventHandler(this.DataBaseConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostDB;
        private System.Windows.Forms.TextBox UsernameDB;
        private System.Windows.Forms.TextBox PasswordDB;
        private System.Windows.Forms.TextBox DatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConnectDB;
    }
}
/*
namespace Generateur_d_interface
{
    partial class DataBaseConnectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.HostDB = new System.Windows.Forms.TextBox();
            this.UsernameDB = new System.Windows.Forms.TextBox();
            this.PasswordDB = new System.Windows.Forms.TextBox();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostDB
            // 
            this.HostDB.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.HostDB.Location = new System.Drawing.Point(215, 75);
            this.HostDB.Multiline = true;
            this.HostDB.Name = "HostDB";
            this.HostDB.Size = new System.Drawing.Size(258, 30);
            this.HostDB.TabIndex = 0;
            this.HostDB.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.HostDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // UsernameDB
            // 
            this.UsernameDB.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.UsernameDB.Location = new System.Drawing.Point(215, 124);
            this.UsernameDB.Multiline = true;
            this.UsernameDB.Name = "UsernameDB";
            this.UsernameDB.Size = new System.Drawing.Size(258, 30);
            this.UsernameDB.TabIndex = 1;
            this.UsernameDB.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.UsernameDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // PasswordDB
            // 
            this.PasswordDB.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.PasswordDB.Location = new System.Drawing.Point(215, 172);
            this.PasswordDB.Multiline = true;
            this.PasswordDB.Name = "PasswordDB";
            this.PasswordDB.Size = new System.Drawing.Size(258, 30);
            this.PasswordDB.TabIndex = 2;
            this.PasswordDB.UseSystemPasswordChar = true;
            this.PasswordDB.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.PasswordDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // DatabaseName
            // 
            this.DatabaseName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DatabaseName.Location = new System.Drawing.Point(215, 228);
            this.DatabaseName.Multiline = true;
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(258, 30);
            this.DatabaseName.TabIndex = 3;
            this.DatabaseName.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.DatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label2.Location = new System.Drawing.Point(49, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label4.Location = new System.Drawing.Point(49, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database:";
            // 
            // ConnectDB
            // 
            this.ConnectDB.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.ConnectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectDB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ConnectDB.ForeColor = System.Drawing.Color.White;
            this.ConnectDB.Location = new System.Drawing.Point(265, 300);
            this.ConnectDB.Name = "ConnectDB";
            this.ConnectDB.Size = new System.Drawing.Size(123, 45);
            this.ConnectDB.TabIndex = 8;
            this.ConnectDB.Text = "Connect";
            this.ConnectDB.UseVisualStyleBackColor = false;
            this.ConnectDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectDB.Click += new System.EventHandler(this.ConnectDB_Click);
            // 
            // DataBaseConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.ConnectDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.PasswordDB);
            this.Controls.Add(this.UsernameDB);
            this.Controls.Add(this.HostDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(542, 489);
            this.MinimumSize = new System.Drawing.Size(542, 489);
            this.Name = "DataBaseConnectionForm";
            this.Text = "UIGen - Database Connection";
            this.Load += new System.EventHandler(this.DataBaseConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostDB;
        private System.Windows.Forms.TextBox UsernameDB;
        private System.Windows.Forms.TextBox PasswordDB;
        private System.Windows.Forms.TextBox DatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConnectDB;
    }
}
*/