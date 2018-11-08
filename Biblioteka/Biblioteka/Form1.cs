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
            loadBooks();
            this.listBox1.Items.Add("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void loadBooks()
        {
            foreach ( Book book in dbDataContext.Books.OrderBy(x => x.Title) )
            {            
                this.listBox1.Items.Add(book.Title.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = dbDataContext.Books.Count() + 4;
            book.Title = this.textBox1.Text.ToString();
            book.Description = "Kurs programowania w języku C#";
            book.Year = 2018;
            dbDataContext.Books.InsertOnSubmit(book);
            dbDataContext.SubmitChanges();
            this.listBox1.Items.Add(book.Title.ToString());
            //loadBooks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
