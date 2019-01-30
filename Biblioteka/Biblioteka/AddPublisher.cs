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
    public partial class AddPublisher : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> errList = new List<string>();
            if (!Validation.validName(this.textBox1.Text.ToString()))
                errList.Add("Wprowadzono błędną nazwę wydawnictwa.");

            if (errList.Count == 0)
            {
                Publishers publisher = new Publishers();
                publisher.Name = this.textBox1.Text.ToString();
                dbDataContext.Publishers.InsertOnSubmit(publisher);
                dbDataContext.SubmitChanges();
                MessageBox.Show("Wydawnictwo dodane.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść ?", "Zakończ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
