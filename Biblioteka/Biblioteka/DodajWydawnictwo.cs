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
    public partial class DodajWydawnictwo : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public DodajWydawnictwo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            Publishers publisher = new Publishers();

            publisher.Name = this.textBox1.Text.ToString();
            dbDataContext.Publishers.InsertOnSubmit(publisher);
            dbDataContext.SubmitChanges();
            MessageBox.Show("Wydawnictwo dodane.");
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {

        }
    }
}
