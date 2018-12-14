namespace Biblioteka
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFlat = new System.Windows.Forms.TextBox();
            this.tbHouseNum = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.cbPassword);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(15, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 109);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasło czytelnika";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(123, 27);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(200, 30);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.Text = "Hasło";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPassword.Location = new System.Drawing.Point(167, 70);
            this.cbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(122, 17);
            this.cbPassword.TabIndex = 8;
            this.cbPassword.Text = "Wygeneruj hasło";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Maroon;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(98, 407);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(285, 33);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Załóż kartę";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbFlat);
            this.groupBox1.Controls.Add(this.tbHouseNum);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbStreet);
            this.groupBox1.Controls.Add(this.tbPostCode);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(461, 250);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane czytelnika";
            // 
            // tbFlat
            // 
            this.tbFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFlat.ForeColor = System.Drawing.Color.Silver;
            this.tbFlat.Location = new System.Drawing.Point(350, 115);
            this.tbFlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFlat.Multiline = true;
            this.tbFlat.Name = "tbFlat";
            this.tbFlat.Size = new System.Drawing.Size(83, 30);
            this.tbFlat.TabIndex = 6;
            this.tbFlat.Text = "Nr lokalu";
            this.tbFlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFlat.Click += new System.EventHandler(this.tbFlat_Click);
            // 
            // tbHouseNum
            // 
            this.tbHouseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHouseNum.ForeColor = System.Drawing.Color.Silver;
            this.tbHouseNum.Location = new System.Drawing.Point(254, 115);
            this.tbHouseNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHouseNum.Multiline = true;
            this.tbHouseNum.Name = "tbHouseNum";
            this.tbHouseNum.Size = new System.Drawing.Size(83, 30);
            this.tbHouseNum.TabIndex = 5;
            this.tbHouseNum.Text = "Nr domu";
            this.tbHouseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHouseNum.Click += new System.EventHandler(this.tbHouseNum_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPhone.ForeColor = System.Drawing.Color.Silver;
            this.tbPhone.Location = new System.Drawing.Point(158, 203);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(150, 30);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.Text = "Telefon";
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhone.Click += new System.EventHandler(this.tbPhone_Click);
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMail.ForeColor = System.Drawing.Color.Silver;
            this.tbMail.Location = new System.Drawing.Point(105, 160);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMail.Multiline = true;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(250, 30);
            this.tbMail.TabIndex = 5;
            this.tbMail.Text = "E-mail";
            this.tbMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMail.Click += new System.EventHandler(this.tbMail_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSurname.ForeColor = System.Drawing.Color.Silver;
            this.tbSurname.Location = new System.Drawing.Point(240, 29);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 30);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.Text = "Nazwisko";
            this.tbSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSurname.Click += new System.EventHandler(this.tbSurname_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.Color.Silver;
            this.tbName.Location = new System.Drawing.Point(24, 29);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 30);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Imię";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStreet.ForeColor = System.Drawing.Color.Silver;
            this.tbStreet.Location = new System.Drawing.Point(35, 115);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStreet.Multiline = true;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(205, 30);
            this.tbStreet.TabIndex = 2;
            this.tbStreet.Text = "Ulica";
            this.tbStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStreet.Click += new System.EventHandler(this.tbStreet_Click);
            // 
            // tbPostCode
            // 
            this.tbPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPostCode.ForeColor = System.Drawing.Color.Silver;
            this.tbPostCode.Location = new System.Drawing.Point(55, 72);
            this.tbPostCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPostCode.Multiline = true;
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(110, 30);
            this.tbPostCode.TabIndex = 4;
            this.tbPostCode.Text = "Kod pocztowy";
            this.tbPostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPostCode.Click += new System.EventHandler(this.tbPostCode_Click);
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCity.ForeColor = System.Drawing.Color.Silver;
            this.tbCity.Location = new System.Drawing.Point(179, 72);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity.Multiline = true;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(235, 30);
            this.tbCity.TabIndex = 3;
            this.tbCity.Text = "Miasto";
            this.tbCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCity.Click += new System.EventHandler(this.tbCity_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka.Properties.Resources.folders;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Rejestracja czytelnika";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFlat;
        private System.Windows.Forms.TextBox tbHouseNum;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbCity;
    }
}