namespace Biblioteka
{
    partial class Orders
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odbierz zaznaczone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zmień tryb";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvItems
            // 
            this.lvItems.CheckBoxes = true;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cSurname,
            this.cRentDate,
            this.cReturnDate,
            this.cBookName,
            this.cStatus});
            this.lvItems.GridLines = true;
            this.lvItems.Location = new System.Drawing.Point(12, 12);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(937, 407);
            this.lvItems.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvItems.TabIndex = 3;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            // 
            // cSurname
            // 
            this.cSurname.Text = "Imię i nazwisko";
            this.cSurname.Width = 160;
            // 
            // cRentDate
            // 
            this.cRentDate.Text = "Data wypożyczenia";
            this.cRentDate.Width = 160;
            // 
            // cReturnDate
            // 
            this.cReturnDate.Text = "Data zwrotu";
            this.cReturnDate.Width = 148;
            // 
            // cBookName
            // 
            this.cBookName.Text = "Nazwa książki";
            this.cBookName.Width = 143;
            // 
            // cStatus
            // 
            this.cStatus.Text = "Stan";
            this.cStatus.Width = 70;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(781, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wyślij przypomnienie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(964, 474);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader cSurname;
        private System.Windows.Forms.ColumnHeader cRentDate;
        private System.Windows.Forms.ColumnHeader cReturnDate;
        private System.Windows.Forms.ColumnHeader cBookName;
        private System.Windows.Forms.ColumnHeader cStatus;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.Button button3;
    }
}