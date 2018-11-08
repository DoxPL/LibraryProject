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
    public partial class Login : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mailInput = this.tbEmail.Text.ToString();
            if (dbDataContext.Users.Where(x => x.Email == mailInput).Select(x => x.Email).Count() == 1)
            {
                MessageBox.Show("Ok");
            }
            this.Close();
        }
    }
}
