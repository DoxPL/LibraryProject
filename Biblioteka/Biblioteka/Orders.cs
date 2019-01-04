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
    public partial class Orders : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void loadOrders()
        {
            foreach (BookRental bookRental in dbDataContext.BookRentals.OrderBy(x => x.RentDate))
            {
                Users user = dbDataContext.Users.Where(x => x.ID == bookRental.ReaderID).First();
                BookCopy bookCopy = dbDataContext.BookCopies.Where(x => x.ID == bookRental.CopyID).First();
                Books book = dbDataContext.Books.Where(x => x.ID == bookCopy.BookID).First(); //name
                this.lOrders.Items.Add(
                        (user.Name + " " + user.Surname) + "\t" +
                        bookRental.RentDate + "\t" +
                        bookRental.ReturnDate + "\t" +
                        book.Title
                    );
            }
        }

        private void lOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
