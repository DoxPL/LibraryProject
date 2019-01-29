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
    public partial class BookListForm : Form
    {
        DataClasses1DataContext dbDataContext = new DataClasses1DataContext();
       
        private void List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDbDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDbDataSet.Books);
            lbUser.Text = (Program.loggedUser.Name + " " + Program.loggedUser.Surname);
            lbUser.Text += " (" + ((Program.loggedUser.AdminStatus == 0) ? "Czytelnik" : "Administrator") + ")";
            loadBooks();
        }

        private ImageList loadImages()
        {
            ImageList images = new ImageList();
            images.ImageSize = new Size(55, 55);
            foreach (Books book in dbDataContext.Books.OrderByDescending(x => x.Title))
            {
                string path = book.ImageLocation;
                if (path != null)
                    images.Images.Add(book.ID.ToString(), Image.FromFile(path));
                else
                    images.Images.Add(book.ID.ToString(), Image.FromFile("img.jpg"));
            }
            return images;
        }

        private void loadBooks()
        {
            // imageList.Images.Add(Image.FromFile("C:/Users/Dox/Desktop/Dominik Galoch/i.png"));
            // lvItems.SmallImageList = imageList;

            try
            {
                lvItems.SmallImageList = loadImages();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            foreach (Books book in dbDataContext.Books.OrderByDescending(x => x.Title))
            {

                var item = new ListViewItem(new[]
                    {
                            book.Title.ToString(),
                            book.Description.ToString(),
                            book.Publishers.Name.ToString(),
                            typesToString(getTypes(book.ID)),
                            book.Year.ToString(),
                            book.ID.ToString()
                    }
                );

                item.ImageKey = book.ID.ToString();
                this.lvItems.Items.Add(item);
            }
        }

        public BookListForm()
        {
            InitializeComponent();
        }

        public string typesToString(List<string> list)
        {
            string str = "";
            foreach (string type in list)
            {
                str += type + " ";
            }
            return str;
        }

        private List<string> getTypes(int bookID)
        {
            List<string> list = new List<string>();
            try
            {
                foreach (BookTypes bookType in dbDataContext.BookTypes.Where(x => x.BookID == bookID))
                {
                    Types type = dbDataContext.Types.Where(x => x.ID == bookType.TypeID).First();
                    list.Add(type.Name);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvItems.Items)
            {
                if (item.Selected)
                {
                    int id = int.Parse(item.SubItems[5].Text);
                    Books book = dbDataContext.Books.Where(x => x.ID == id).First();
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
                    MessageBox.Show("Wypożyczono: " + book.Title);
                }
            }
        }
        private int getFreeCopy(int bookID)
        {
            //Zwraca pierwszy znaleziony wolny egzemplarz książki
            int copyID = -1;
            if (dbDataContext.BookCopies.Where(x => x.BookID == bookID).Where(y => y.Free == 1).Count() > 0)
                return dbDataContext.BookCopies.Where(x => x.BookID == bookID).Where(y => y.Free == 1).Select(z => z.ID).First();
            return copyID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvItems.SelectedItems.Clear();
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Orders().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminPanel().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lvItems.Refresh();
        }
    }
}
