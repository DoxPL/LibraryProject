using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class DodajGatunek : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();

        public DodajGatunek()
        {
            InitializeComponent();
        }

        private void DodajGatunek_Load(object sender, EventArgs e)
        {

        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść ?", "Zakończ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            Types type = new Types();
            type.Name = this.textBox1.Text.ToString();
            dbDataContext.Types.InsertOnSubmit(type);
            dbDataContext.SubmitChanges();
            MessageBox.Show("Gatunek został dodany.");
        }
    }
}
