namespace Biblioteka
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.libraryDbDataSet = new Biblioteka.libraryDbDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Biblioteka.libraryDbDataSetTableAdapters.UsersTableAdapter();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.wyswietl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bib = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDbDataSet
            // 
            this.libraryDbDataSet.DataSetName = "libraryDbDataSet";
            this.libraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumDataGridViewTextBoxColumn,
            this.flatDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.adminStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1242, 349);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseNumDataGridViewTextBoxColumn
            // 
            this.houseNumDataGridViewTextBoxColumn.DataPropertyName = "HouseNum";
            this.houseNumDataGridViewTextBoxColumn.HeaderText = "HouseNum";
            this.houseNumDataGridViewTextBoxColumn.Name = "houseNumDataGridViewTextBoxColumn";
            // 
            // flatDataGridViewTextBoxColumn
            // 
            this.flatDataGridViewTextBoxColumn.DataPropertyName = "Flat";
            this.flatDataGridViewTextBoxColumn.HeaderText = "Flat";
            this.flatDataGridViewTextBoxColumn.Name = "flatDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // adminStatusDataGridViewTextBoxColumn
            // 
            this.adminStatusDataGridViewTextBoxColumn.DataPropertyName = "AdminStatus";
            this.adminStatusDataGridViewTextBoxColumn.HeaderText = "AdminStatus";
            this.adminStatusDataGridViewTextBoxColumn.Name = "adminStatusDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.libraryDbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(320, 377);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(120, 35);
            this.addGenreButton.TabIndex = 3;
            this.addGenreButton.Text = "edytuj użytkownika";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(62, 379);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(105, 33);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "dodaj użytkownika";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(187, 378);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(117, 34);
            this.addAuthorButton.TabIndex = 2;
            this.addAuthorButton.Text = "usuń użytkownika";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // wyswietl
            // 
            this.wyswietl.Location = new System.Drawing.Point(1031, 376);
            this.wyswietl.Name = "wyswietl";
            this.wyswietl.Size = new System.Drawing.Size(127, 35);
            this.wyswietl.TabIndex = 6;
            this.wyswietl.Text = "Wyświetl";
            this.wyswietl.UseVisualStyleBackColor = true;
            this.wyswietl.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj książkę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 378);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Dodaj gatunek";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 378);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Dodaj wydawnictwo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bib
            // 
            this.bib.Location = new System.Drawing.Point(749, 376);
            this.bib.Name = "bib";
            this.bib.Size = new System.Drawing.Size(131, 33);
            this.bib.TabIndex = 10;
            this.bib.Text = "Biblioteka";
            this.bib.UseVisualStyleBackColor = true;
            this.bib.Click += new System.EventHandler(this.bib_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.bib);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wyswietl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.addBookButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.Text = "Panel administratora";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private libraryDbDataSet libraryDbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private libraryDbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button wyswietl;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bib;
    }
}