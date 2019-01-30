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
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDbDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDbDataSet.Publishers);

        }
    }
}
