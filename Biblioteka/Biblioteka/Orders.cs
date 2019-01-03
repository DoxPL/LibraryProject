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
            DateTime today = DateTime.Today;
            foreach (BookRental bookRental in dbDataContext.BookRentals.OrderByDescending(x => x.ID))
            {
                Users user = dbDataContext.Users.Where(x => x.ID == bookRental.ReaderID).First();
                BookCopy bookCopy = dbDataContext.BookCopies.Where(x => x.ID == bookRental.CopyID).First();
                Books book = dbDataContext.Books.Where(x => x.ID == bookCopy.BookID).First(); //name
                DateTime returnDate = bookRental.RentDate.AddDays(30);
                bool status = (returnDate.CompareTo(today) > 0);
                var item = new ListViewItem(new[]
                    {
                        bookRental.ID.ToString(),
                        (user.Name + " " + user.Surname).ToString(),
                        bookRental.RentDate.ToString(),
                        returnDate.ToString(),
                        book.Title.ToString(),
                        status ? "Wypożyczona" : "Nieoddana"
                    }
                );
                this.lvItems.Items.Add(item);
            }
            this.lvItems.ListViewItemSorter = new LvComparer(0);
            //this.lvItems.Sorting = SortOrder.Descending;
        }


        private void lOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvItems.Items)
            {
                if (item.Checked)
                    item.Remove();
                //usuń z bazy danych
            }
        }
    }
}
