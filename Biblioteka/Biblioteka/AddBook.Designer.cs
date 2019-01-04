namespace Biblioteka
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthorName = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.comboBoxPublishers = new System.Windows.Forms.ComboBox();
            this.tbAuthorSurname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddBook.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBook.Location = new System.Drawing.Point(124, 469);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(380, 41);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Dodaj książkę";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(64, 31);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(39, 17);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Tytuł";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAuthor.Location = new System.Drawing.Point(64, 76);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(148, 17);
            this.lbAuthor.TabIndex = 11;
            this.lbAuthor.Text = "Autor - imię i nazwisko";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbYear.Location = new System.Drawing.Point(64, 122);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(88, 17);
            this.lbYear.TabIndex = 12;
            this.lbYear.Text = "Rok wydania";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPublisher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPublisher.Location = new System.Drawing.Point(64, 167);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(68, 17);
            this.lbPublisher.TabIndex = 13;
            this.lbPublisher.Text = "Wydawca";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbType.Location = new System.Drawing.Point(64, 213);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(62, 17);
            this.lbType.TabIndex = 14;
            this.lbType.Text = "Gatunek";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDescription.Location = new System.Drawing.Point(65, 258);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(37, 17);
            this.lbDescription.TabIndex = 15;
            this.lbDescription.Text = "Opis";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(68, 49);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(379, 22);
            this.tbTitle.TabIndex = 16;
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.Location = new System.Drawing.Point(68, 95);
            this.tbAuthorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.Size = new System.Drawing.Size(185, 22);
            this.tbAuthorName.TabIndex = 17;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(68, 140);
            this.tbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(379, 22);
            this.tbYear.TabIndex = 19;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(68, 277);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(379, 22);
            this.tbDescription.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Biblioteka.Properties.Resources.panel_bg;
            this.panel1.Controls.Add(this.listBoxTypes);
            this.panel1.Controls.Add(this.comboBoxPublishers);
            this.panel1.Controls.Add(this.tbAuthorSurname);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Controls.Add(this.lbAuthor);
            this.panel1.Controls.Add(this.tbYear);
            this.panel1.Controls.Add(this.tbAuthorName);
            this.panel1.Controls.Add(this.lbPublisher);
            this.panel1.Controls.Add(this.lbYear);
            this.panel1.Location = new System.Drawing.Point(56, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 342);
            this.panel1.TabIndex = 2;
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.ItemHeight = 16;
            this.listBoxTypes.Location = new System.Drawing.Point(68, 233);
            this.listBoxTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTypes.Size = new System.Drawing.Size(379, 20);
            this.listBoxTypes.TabIndex = 23;
            // 
            // comboBoxPublishers
            // 
            this.comboBoxPublishers.FormattingEnabled = true;
            this.comboBoxPublishers.Location = new System.Drawing.Point(68, 183);
            this.comboBoxPublishers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPublishers.Name = "comboBoxPublishers";
            this.comboBoxPublishers.Size = new System.Drawing.Size(379, 24);
            this.comboBoxPublishers.TabIndex = 20;
            // 
            // tbAuthorSurname
            // 
            this.tbAuthorSurname.Location = new System.Drawing.Point(261, 95);
            this.tbAuthorSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAuthorSurname.Name = "tbAuthorSurname";
            this.tbAuthorSurname.Size = new System.Drawing.Size(185, 22);
            this.tbAuthorSurname.TabIndex = 18;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddBook);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBook";
            this.Text = "Dodawanie książki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBook_FormClosing);
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbAuthorName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAuthorSurname;
        private System.Windows.Forms.ComboBox comboBoxPublishers;
        private System.Windows.Forms.ListBox listBoxTypes;
    }
}