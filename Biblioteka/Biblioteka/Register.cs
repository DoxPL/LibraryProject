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
        bool rndPassword = false;
        string password = "";
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public Register()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbPassword.Checked)
            {
                this.lbPassword.Visible = false;
                this.tbPassword.Visible = false;
                this.rndPassword = true;
            }
            else
            {
                this.lbPassword.Visible = true;
                this.tbPassword.Visible = true;
                this.rndPassword = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            List<string> errList = new List<string>();
            if (!Validation.validEmail(this.tbMail.Text.ToString()))
                errList.Add("Nieprawidłowy adres e-mail");
            else if (!Validation.validPassword(this.tbPassword.Text.ToString()) && !rndPassword)
                errList.Add("Hasło musi mieć przynajmniej dwie liczby oraz jedną dużą literę");
            else if (!Validation.validPostcode(this.tbPostCode.Text.ToString()))
                errList.Add("Nieprawidłowy kod pocztowy");
            else if (!Validation.validStreet(this.tbStreet.Text.ToString()))
                errList.Add("Podana ulica jest nieprawidłowa");
            else if (!Validation.validPhoneNumber(this.tbPhone.Text.ToString()))
                errList.Add("Nieprawidłowy numer telefonu");
            else if (!Validation.validName(this.tbName.Text.ToString()))
                errList.Add("Błędna nazwa");

            if (errList.Count == 0)
            {
                Users user = new Users();
                user.Name = this.tbName.Text.ToString();
                user.Surname = this.tbSurname.Text.ToString();
                user.Street = this.tbStreet.Text.ToString();
                user.City = this.tbCity.Text.ToString();
                user.PostCode = this.tbPostCode.Text.ToString();
                user.Email = this.tbMail.Text.ToString();
                if (!rndPassword)
                {
                    user.Password = PasswordUtil.PasswordHash(this.tbPassword.Text.ToString());
                    MessageBox.Show(user.Password);
                }
                else
                {
                    this.password = PasswordUtil.GeneratePassword(10);
                    user.Password = PasswordUtil.PasswordHash(password);
                }
                dbDataContext.Users.InsertOnSubmit(user);
                dbDataContext.SubmitChanges();
                MessageBox.Show("Zarejestrowano czytelnika w systemie" + ((rndPassword) ?
                    ("\nWygenerowane hasło: " + this.password) : ""));
                this.Close();
            }
            else
            {
                string errOutput = "";
                foreach(var errMsg in errList)
                {
                    errOutput += (errMsg.ToString() + "\n");
                }
                MessageBox.Show(errOutput);
            }
        }

        private void tvMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Zakończ", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
