﻿using System;
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
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public AddBook()
        {
            InitializeComponent();

            comboBoxPublishers.Items.AddRange(dbDataContext.Publishers.ToArray());
            comboBoxPublishers.DisplayMember = "Name";

            listBoxTypes.Items.AddRange(dbDataContext.Types.ToArray());
            listBoxTypes.DisplayMember = "Name";

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            Authors author = new Authors();

            book.Title = this.tbTitle.Text.ToString();
            author.Name = this.tbAuthorName.Text.ToString();
            author.Surname = this.tbAuthorSurname.Text.ToString();
            //book.Year =
            book.Description = this.tbDescription.Text.ToString();

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

            dbDataContext.Books.InsertOnSubmit(book);
            dbDataContext.SubmitChanges();
            //this.listBox1.Items.Add(book.Title.ToString());
            
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
    }
}