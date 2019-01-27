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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDbDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.libraryDbDataSet.Users);

            if (Program.loggedUser.AdminStatus == 0)
            {
                addBookButton.Enabled = false;
                addGenreButton.Enabled = false;
                addPublisherButton.Enabled = false;
                addAuthorButton.Enabled = false;
            }

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.Show();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            AddGenre addGenre = new AddGenre();
            addGenre.Show();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            AddPublisher addPublisher = new AddPublisher();
            addPublisher.Show();
        }

        private void bib_Click(object sender, EventArgs e)
        {
            new BookListForm().Show();
        }
    }
}
