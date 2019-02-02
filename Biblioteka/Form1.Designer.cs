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
            this.panelMain = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = global::Biblioteka.Properties.Resources.panel_bg;
            this.panelMain.Controls.Add(this.button6);
            this.panelMain.Controls.Add(this.adminPanelButton);
            this.panelMain.Controls.Add(this.lbUser);
            this.panelMain.Controls.Add(this.orders);
            this.panelMain.Controls.Add(this.button5);
            this.panelMain.Location = new System.Drawing.Point(129, 67);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(403, 389);
            this.panelMain.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(51, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(300, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "Lista książek";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bookList_Click);
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminPanelButton.Location = new System.Drawing.Point(51, 288);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(300, 50);
            this.adminPanelButton.TabIndex = 13;
            this.adminPanelButton.Text = "Panel administratora";
            this.adminPanelButton.UseVisualStyleBackColor = true;
            this.adminPanelButton.Click += new System.EventHandler(this.adminPanelButton_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUser.Location = new System.Drawing.Point(47, 18);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(137, 20);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Zalogowano jako: ";
            // 
            // orders
            // 
            this.orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orders.Location = new System.Drawing.Point(51, 183);
            this.orders.Margin = new System.Windows.Forms.Padding(2);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(300, 50);
            this.orders.TabIndex = 12;
            this.orders.Text = "Wypożyczenia";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(51, 115);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 50);
            this.button5.TabIndex = 11;
            this.button5.Text = "Dodaj książkę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.addBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::Biblioteka.Properties.Resources.mainthemev2;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button adminPanelButton;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button button5;
    }
}

