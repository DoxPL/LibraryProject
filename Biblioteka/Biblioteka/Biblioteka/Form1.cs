﻿using Biblioteka.Resources;
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

            comboBoxPublishers.Items.AddRange(dbDataContext.Publishers.ToArray());
            comboBoxPublishers.DisplayMember = "Name";

            listBoxTypes.Items.AddRange(dbDataContext.Types.ToArray());
            listBoxTypes.DisplayMember = "Name";
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
            this.lbUser.Text += (Program.loggedUser.Name + " " + Program.loggedUser.Surname);
        }

        private void loadBooks()
        {
            foreach ( Books book in dbDataContext.Books.OrderBy(x => x.Title) )
            {            
                this.listBox1.Items.Add(book.Title.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Title = this.textBox1.Text.ToString();
            book.Description = "Kurs programowania w języku C#";
            book.Year = 2018;
            if (comboBoxPublishers.SelectedItem == null)
            {
                book.Publishers = new Publishers();
                book.Publishers.Name = comboBoxPublishers.Text;
            }
            else
            {
                book.Publishers = (Publishers)comboBoxPublishers.SelectedItem;
            }
            
            foreach(Types t in listBoxTypes.SelectedItems)
            {
                BookTypes bt = new BookTypes();
                bt.Books = book;
                bt.Types = t;
            }

            dbDataContext.Books.InsertOnSubmit(book);
            dbDataContext.SubmitChanges();
            this.listBox1.Items.Add(book.Title.ToString());
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

        private void lbAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dodawanie egzemplarzy do tabeli wypożyczeń
            foreach (string bookTitle in listBox1.SelectedItems)
            {
                Books book = dbDataContext.Books.Where(x => x.Title == bookTitle).First();
                BookRental rental = new BookRental();
                rental.ReaderID = Program.loggedUser.ID;
                rental.RentDate = DateTime.Now;
                rental.ReturnDate = DateTime.Now.AddDays(30);
                int freeCopy = getFreeCopy(book.ID);
                if (freeCopy == -1)
                {
                    MessageBox.Show("Brak wolnego egzemplarza");
                    break;
                }
                rental.CopyID = freeCopy;
                rental.status = 1;
                dbDataContext.BookRentals.InsertOnSubmit(rental);
                BookCopy bc = dbDataContext.BookCopies.Where(x => x.ID == freeCopy).First();
                bc.Free = 0;
                dbDataContext.SubmitChanges();
                MessageBox.Show(book.Title);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Orders().Show();
        }

        private int getFreeCopy(int bookID)
        {
            //Zwraca pierwszy znaleziony wolny egzemplarz książki
            int copyID = -1;
            if (dbDataContext.BookCopies.Where(x => x.BookID == bookID).Where(y => y.Free == 1).Count() > 0)
                return dbDataContext.BookCopies.Where(x => x.BookID == bookID).Where(y => y.Free == 1).Select(z => z.ID).First();
            return copyID;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddBook bookForm = new AddBook();
            bookForm.Show();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Stworzone do testowania mozna skasowac komentrze ponizej: 
            //DodajAutora dodajAutora = new DodajAutora();
            //dodajAutora.Show();
            //DodajGatunek dodajGatunek = new DodajGatunek();
            //dodajGatunek.Show();
            DodajWydawnictwo dodajWydawnictwo = new DodajWydawnictwo();
            dodajWydawnictwo.Show();
        }
    }
}
