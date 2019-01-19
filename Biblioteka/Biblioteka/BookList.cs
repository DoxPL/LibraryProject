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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDbDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDbDataSet.Books);

        }

        private void order_Click(object sender, EventArgs e)
        {
            //Dodawanie egzemplarzy do tabeli wypożyczeń
            /*foreach (string bookTitle in listBox1.SelectedItems)
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
            }*/
        }
    }
}
