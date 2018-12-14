namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLogin = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbAdmin = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxPublishers = new System.Windows.Forms.ComboBox();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLogin.Location = new System.Drawing.Point(993, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Padding = new System.Windows.Forms.Padding(0, 2, 11, 0);
            this.lbLogin.Size = new System.Drawing.Size(66, 19);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.TabStop = true;
            this.lbLogin.Text = "Zaloguj";
            this.lbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogin_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1035, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista książek";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1023, 452);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAdmin.Location = new System.Drawing.Point(837, 0);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Padding = new System.Windows.Forms.Padding(0, 2, 11, 0);
            this.lbAdmin.Size = new System.Drawing.Size(156, 19);
            this.lbAdmin.TabIndex = 2;
            this.lbAdmin.TabStop = true;
            this.lbAdmin.Text = "Panel administracyjny";
            this.lbAdmin.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 526);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rejestracja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxPublishers
            // 
            this.comboBoxPublishers.FormattingEnabled = true;
            this.comboBoxPublishers.Location = new System.Drawing.Point(356, 526);
            this.comboBoxPublishers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPublishers.Name = "comboBoxPublishers";
            this.comboBoxPublishers.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPublishers.TabIndex = 6;
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.ItemHeight = 16;
            this.listBoxTypes.Location = new System.Drawing.Point(524, 526);
            this.listBoxTypes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTypes.Size = new System.Drawing.Size(159, 20);
            this.listBoxTypes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 571);
            this.Controls.Add(this.listBoxTypes);
            this.Controls.Add(this.comboBoxPublishers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lbAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxPublishers;
        private System.Windows.Forms.ListBox listBoxTypes;
    }
}

