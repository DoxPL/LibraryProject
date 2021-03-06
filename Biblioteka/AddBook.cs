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
    public partial class AddBook : Form
    {
        private string img;
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public AddBook()
        {
            InitializeComponent();

            comboBoxPublishers.Items.AddRange(dbDataContext.Publishers.ToArray());
            comboBoxPublishers.DisplayMember = "Name";

            listBoxTypes.Items.AddRange(dbDataContext.Types.ToArray());
            listBoxTypes.DisplayMember = "Name";

            lbAuthors.Items.AddRange(dbDataContext.Authors.ToArray());
            lbAuthors.DisplayMember = "Surname";
           

            int[] years = new int[2019];
            for (int i = 1; i < years.Length; i++)
            {
                years[i] = i;
            }

            System.Object[] ItemObject = new System.Object[2019];
            int h = 2019;
            for (int i = 0; i < years.Length; i++)
            {
                ItemObject[i] = h;
                h--;
            }
            comboBoxYears.Items.AddRange(ItemObject);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
            List<string> errList = new List<string>();
            if (!Validation.validTitle(this.tbTitle.Text.ToString()))
                errList.Add("Nieprawidłowy tytuł. Można używać tylko liter.");
            /*else if (!Validation.validName(this.tbAuthorName.Text.ToString()))
                errList.Add("Nieprawidłowe imię");
            else if (!Validation.validName(this.tbAuthorSurname.Text.ToString()))
                errList.Add("Nieprawidłowe nazwisko"); */
            else if (!Validation.validYear(this.comboBoxYears.Text.ToString()))
                errList.Add("Nieprawidłowy rok. Należy wpisać rok od 1 do 2019. Należy używać tylko cyfr.");
            else if (comboBoxYears.Text != "")
            {
                int yr = int.Parse(this.comboBoxYears.Text);
                if (yr > 2019)
                    errList.Add("Rok nie może być większy niż 2019");
                else if (yr < 1)
                    errList.Add("Rok nie może być mniejszy niż 1");
            }
            else if (!Validation.validName(this.comboBoxPublishers.Text.ToString()))
                errList.Add("Nieprawidłowa nazwa wydawcy");
            else if (!Validation.validCount(this.bcCount.Text.ToString()))
                errList.Add("Nieprawidłowa ilość egzemplarzy");

            if (errList.Count == 0)
            {
                Books book = new Books();
                Authors author = new Authors();

                book.Title = this.tbTitle.Text.ToString();
                /*author.Name = this.tbAuthorName.Text.ToString();
                author.Surname = this.tbAuthorSurname.Text.ToString(); */
                book.Year = int.Parse(this.comboBoxYears.Text.ToString());

                book.Description = this.tbDescription.Text.ToString();
                if (this.img != null)
                    book.ImageLocation = "covers/" + img;

                if (comboBoxPublishers.SelectedItem == null)
                {
                    book.Publishers = new Publishers();
                    book.Publishers.Name = comboBoxPublishers.Text;
                }
                else
                {
                    book.Publishers = (Publishers)comboBoxPublishers.SelectedItem;
                }

                foreach (Types t in listBoxTypes.SelectedItems)
                {
                    BookTypes bt = new BookTypes();
                    bt.Books = book;
                    bt.Types = t;
                }

                foreach (Authors a in lbAuthors.SelectedItems)
                {
                    Writing writing = new Writing();
                    writing.Books = book;
                    writing.Authors = a;
                }

                dbDataContext.Books.InsertOnSubmit(book);
                dbDataContext.SubmitChanges();
                addBookCopies(Convert.ToInt32(bcCount.Value), book.ID);
                //this.listBox1.Items.Add(book.Title.ToString());
                MessageBox.Show("Dodawanie książki zakończone sukcesem !");
                Close();
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

        private void addBookCopies(int count, int bookID)
        {
            for (int i = 0; i < count; i++)
            {
                BookCopy bookCopy = new BookCopy();
                bookCopy.Free = 1;
                bookCopy.BookID = bookID;
                dbDataContext.BookCopies.InsertOnSubmit(bookCopy);
                dbDataContext.SubmitChanges();
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getImg();
        }

        private void getImg()
        {
            OpenFileDialog x = new OpenFileDialog();
            if (x.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBox1.ImageLocation = x.FileName;

            this.img = x.SafeFileName;
        }

        private void comboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
