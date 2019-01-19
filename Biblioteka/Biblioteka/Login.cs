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
            login();
        }

        private void login()
        {
            String mailInput = this.tbEmail.Text.ToString();
            String pwdInput = this.tbPass.Text.ToString();

            if (dbDataContext.Users.Where(x => x.Email == mailInput).Select(x => x.Email).Count() == 1)
            {
                string pwdHash = dbDataContext.Users.Where(x => x.Email == mailInput).Select(y => y.Password).First();
                if (pwdHash == PasswordUtil.PasswordHash(pwdInput))
                {
                    this.Hide();
                    MessageBox.Show("Zalogowano pomyślnie");
                    Program.loggedUser = dbDataContext.Users.Where(x => x.Email == mailInput).First();
                    BookListForm bookListForm = new BookListForm();
                    bookListForm.Show();
                }
                else
                {
                    MessageBox.Show("Podane hasło jest nieprawidłowe");
                }
            }
            else
            {
                if (mailInput != "root")
                    MessageBox.Show("Brak użytkownika w systemie");
                else
                {
                    // Dodawanie użytkownika 'root' jeśli nie ma go w bazie danych
                    Users root = new Users();
                    root.Name = "Administrator";
                    root.Surname = "Root";
                    root.Email = "root";
                    root.Password = PasswordUtil.PasswordHash(pwdInput);
                    dbDataContext.Users.InsertOnSubmit(root);
                    dbDataContext.SubmitChanges();
                    MessageBox.Show("Konto administratora zostało zarejestrowane");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                login();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
        }
    }
}