namespace Biblioteka
{
    partial class BookListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            this.libraryDbDataSet = new Biblioteka.libraryDbDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Biblioteka.libraryDbDataSetTableAdapters.BooksTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.cTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryDbDataSet
            // 
            this.libraryDbDataSet.DataSetName = "libraryDbDataSet";
            this.libraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDbDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 800);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Biblioteka.Properties.Resources.panel_bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.lvItems);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(78, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 680);
            this.panel1.TabIndex = 16;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(849, 586);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(150, 40);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "Odśwież";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // lvItems
            // 
            this.lvItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTitle,
            this.cDescription,
            this.cPub,
            this.cType,
            this.cYear,
            this.cID});
            this.lvItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.Location = new System.Drawing.Point(68, 65);
            this.lvItems.Margin = new System.Windows.Forms.Padding(2);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(931, 500);
            this.lvItems.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvItems.TabIndex = 4;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // cTitle
            // 
            this.cTitle.Text = "Tytuł";
            this.cTitle.Width = 160;
            // 
            // cDescription
            // 
            this.cDescription.Text = "Opis";
            this.cDescription.Width = 152;
            // 
            // cPub
            // 
            this.cPub.Text = "Wydawnictwo";
            this.cPub.Width = 148;
            // 
            // cType
            // 
            this.cType.Text = "Gatunek";
            this.cType.Width = 125;
            // 
            // cYear
            // 
            this.cYear.Text = "Rok wydania";
            this.cYear.Width = 114;
            // 
            // cID
            // 
            this.cID.Text = "Identyfikator";
            this.cID.Width = 84;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(695, 586);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Wypożyczenia";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(541, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Odznacz wszystko";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUser.Location = new System.Drawing.Point(194, 634);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(45, 20);
            this.lbUser.TabIndex = 15;
            this.lbUser.Text = "[nick]";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(387, 586);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Wypożycz wybrane";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 634);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Zalogowany jako: ";
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1239, 813);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookListForm";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private libraryDbDataSet libraryDbDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private libraryDbDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader cTitle;
        private System.Windows.Forms.ColumnHeader cDescription;
        private System.Windows.Forms.ColumnHeader cPub;
        private System.Windows.Forms.ColumnHeader cType;
        private System.Windows.Forms.ColumnHeader cYear;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}