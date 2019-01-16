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
        bool selMode = true;
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            loadOrders(true);
        }

        private void loadOrders(bool selectMode)
        {
            DateTime today = DateTime.Today;
            foreach (BookRental bookRental in dbDataContext.BookRentals.OrderByDescending(x => x.ID).
                Where(y => y.status == (selectMode ? 1 : 0)))
            {
                Users user = dbDataContext.Users.Where(x => x.ID == bookRental.ReaderID).First();
                BookCopy bookCopy = dbDataContext.BookCopies.Where(x => x.ID == bookRental.CopyID).First();
                Books book = dbDataContext.Books.Where(x => x.ID == bookCopy.BookID).First(); //name
                DateTime returnDate = (DateTime) bookRental.ReturnDate;
                bool status = (returnDate.CompareTo(today) > 0);
                string strStatus = (bookRental.status == 1) ? (status ? "Wypożyczona" : "Nieoddana") : "Oddana";
                var item = new ListViewItem(new[]
                    {
                        bookRental.ID.ToString(),
                        (user.Name + " " + user.Surname).ToString(),
                        bookRental.RentDate.ToString(),
                        returnDate.ToString(),
                        book.Title.ToString(),
                        strStatus
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
                {
                    item.Remove();
                    int tmpID = int.Parse(item.Text.ToString());
                    try
                    {
                        BookRental dbObject = dbDataContext.BookRentals.SingleOrDefault(x => x.ID == tmpID);
                        dbObject.ReturnDate = (DateTime?) DateTime.Now;
                        dbObject.status = 0;
                        dbDataContext.SubmitChanges();
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearList();
            if (selMode)
            {
                selMode = false;
                loadOrders(false);
                button2.Text = "Wyświetl nieoddane";
                button1.Enabled = false;
            }
            else
            {
                selMode = true;
                loadOrders(true);
                button2.Text = "Wyświetl oddane";
                button1.Enabled = true;
            }
        }

        private void clearList()
        {
            foreach(ListViewItem item in lvItems.Items)
            {
                item.Remove();
            }
        }
    }
}
