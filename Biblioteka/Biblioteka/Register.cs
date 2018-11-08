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
    public partial class Register : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public Register()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbPassword.Checked)
            {
                this.lbPassword.Visible = false;
                this.tbPassword.Visible = false;
            }
            else
            {
                this.lbPassword.Visible = true;
                this.tbPassword.Visible = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Do poprawy
            User user = new User();
            user.Name = this.tbName.Text.ToString();
            user.Surname = this.tbSurname.Text.ToString();
            user.Street = this.tbStreet.Text.ToString();
            user.City = this.tbCity.Text.ToString();
            user.PostCode = this.tbPostCode.Text.ToString();
            user.Email = this.tbMail.Text.ToString();
            user.Password = this.tbPassword.ToString();
            dbDataContext.Users.InsertOnSubmit(user);
            dbDataContext.SubmitChanges();
            MessageBox.Show("Zarejestrowano czytelnika w systemie");
        }

        private void tvMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
