using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class XmlCreator : Form
    {
        public XmlCreator()
        {
            InitializeComponent();
        }

        private void XmlCreator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = new XDocument(new XElement("body",
                                           new XElement("data",
                                               new XElement("host", this.tbHost.Text),
                                               new XElement("login", this.tbUser.Text),
                                               new XElement("pass", this.tbPass.Text))));
            xmlDoc.Save("Email.xml");
            MessageBox.Show("Zapisano dane w pliku XML");
            this.Close();
        }
    }
}
