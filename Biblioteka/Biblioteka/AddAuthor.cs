using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Resources
{
    public partial class DodajAutora : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public DodajAutora()
        {
            InitializeComponent();
        }

        private void DodajAutora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> errList = new List<string>();
            if (!Validation.validName(this.ImieAutora.Text.ToString()))
                errList.Add("Błędne imię");
            else if (!Validation.validName(this.NazwiskoAutora.Text.ToString()))
                errList.Add("Błędne nazwisko");

            if (errList.Count == 0)
            {
                Authors author = new Authors();
                author.Name = this.ImieAutora.Text.ToString();
                author.Surname = this.NazwiskoAutora.Text.ToString();

                dbDataContext.Authors.InsertOnSubmit(author);
                dbDataContext.SubmitChanges();
                MessageBox.Show("Autor został dodany.");
            }
            else
            {
                string errOutput = "";
                foreach (var errMsg in errList)
                {
                    errOutput += (errMsg.ToString() + "\n");
                }
                MessageBox.Show(errOutput);
            }





        }
        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść ?", "Zakończ", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść ?", "Zakończ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
