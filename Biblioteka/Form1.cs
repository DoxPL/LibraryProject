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
    public partial class Form1 : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lbUser.Text += (Program.loggedUser.Name + " " + Program.loggedUser.Surname);
        }

        private void lbAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
        

        private int getFreeCopy(int bookID)
        {
            //Zwraca pierwszy znaleziony wolny egzemplarz książki
            int copyID = -1;
            if (dbDataContext.BookCopies.Where(x => x.BookID == bookID).Where(y => y.Free == 1).Count() > 0)
                return dbDataContext.BookCopies.Where(x => x.BookID == bookID).Where(y => y.Free == 1).Select(z => z.ID).First();
            return copyID;
        }

        private void lbUser_Click(object sender, EventArgs e)
        {
            BookListForm bookList = new BookListForm();
            bookList.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBook bookForm = new AddBook();
            bookForm.Show();
        }

        private void bookList_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList();
            bookList.Show();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            new Orders().Show();
        }
    }
}
