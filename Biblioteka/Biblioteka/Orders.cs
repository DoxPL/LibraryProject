using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
            if (Program.loggedUser.AdminStatus == 0)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
            }
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
                if (Program.loggedUser.AdminStatus == 0 && user.ID != Program.loggedUser.ID)
                    continue;
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
                        BookCopy bc = dbDataContext.BookCopies.Where(x => x.ID == dbObject.CopyID).First();
                        bc.Free = 1;
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
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                selMode = true;
                loadOrders(true);
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void clearList()
        {
            foreach(ListViewItem item in lvItems.Items)
            {
                item.Remove();
            }
        }

        private EmailAccountModel getModelFromXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Email.xml");
            string path = "data/host";
            XmlNode hostNode = xmlDoc.DocumentElement.SelectSingleNode("data/host");
            XmlNode loginNode = xmlDoc.DocumentElement.SelectSingleNode("data/login");
            XmlNode passNode = xmlDoc.DocumentElement.SelectSingleNode("data/pass");
            return new EmailAccountModel(hostNode.InnerText, loginNode.InnerText, loginNode.InnerText, passNode.InnerText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!isXMLExists())
            {
                new XmlCreator().Show();
                return;
            }
            EmailAccountModel model = getModelFromXml();
            int counter = 0;
            foreach (ListViewItem item in lvItems.Items)
            {
                if(item.Checked)
                {
                    int tmpID = int.Parse(item.Text.ToString());
                    BookRental borrowingData = dbDataContext.BookRentals.SingleOrDefault(x => x.ID == tmpID);
                    Users userData = dbDataContext.Users.SingleOrDefault(x => x.ID == borrowingData.ReaderID);
                    BookCopy bookCopy = dbDataContext.BookCopies.SingleOrDefault(x => x.ID == borrowingData.CopyID);
                    Books book = dbDataContext.Books.SingleOrDefault(x => x.ID == bookCopy.BookID);
                    string email = userData.Email;
                    EmailSender emailSender = new EmailSender(model, email, "Nieoddana książka: " + book.Title +
                        ". Prosimy o zwrot");
                    emailSender.send();
                    counter++;
                }
            }
            if (counter == 0)
                MessageBox.Show("Nie wybrano żadnej opcji z listy");
            else if (counter == 1)
                MessageBox.Show("Wiadomość z przypomnieniem została wysłana");
            else
                MessageBox.Show("Wysłano wiadomości z przypomnieniem");
        }

        public bool isXMLExists()
        {
            if (!File.Exists("Email.xml"))
                return false;
            return true;
        }
    }
}
