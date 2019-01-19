using Biblioteka.Resources;
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
            this.usersTableAdapter.Fill(this.libraryDbDataSet.Users);

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
            DodajAutora dodajAutora = new DodajAutora();
            dodajAutora.Show();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            AddGenre dodajGatunek = new AddGenre();
            dodajGatunek.Show();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            AddPublisher dodajWydawnictwo = new AddPublisher();
            dodajWydawnictwo.Show();
        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
