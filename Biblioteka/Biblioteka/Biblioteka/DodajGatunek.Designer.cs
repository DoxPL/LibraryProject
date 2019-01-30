namespace Biblioteka
{
    partial class DodajGatunek
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa nowego gatunku:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.Location = new System.Drawing.Point(33, 93);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(75, 23);
            this.Zatwierdz.TabIndex = 2;
            this.Zatwierdz.Text = "Zatwierdź";
            this.Zatwierdz.UseVisualStyleBackColor = true;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(114, 93);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 3;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // DodajGatunek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(233, 153);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Zatwierdz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DodajGatunek";
            this.Text = "DodajGatunek";
            this.Load += new System.EventHandler(this.DodajGatunek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Zatwierdz;
        private System.Windows.Forms.Button Anuluj;
    }
}