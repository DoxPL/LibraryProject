using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\libraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form2_Load(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [Users] (Name,Surname,Street,HouseNum,Flat,City,PostCode,Email,PhoneNum,Password,AdminStatus) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + 
                "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + 
                "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + 
                "','" + textBox10.Text + "','" + textBox11.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
            textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = "";
            textBox9.Text = ""; textBox10.Text = ""; textBox11.Text = "";
            MessageBox.Show("Dodano użytkownika");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [Users] SET Name = '" + textBox1.Text + "', Surname= '" 
                + textBox2.Text + "', Street= '" + textBox3.Text + "', HouseNum= '" 
                + textBox4.Text + "', Flat= '" + textBox5.Text + "', City= '" + textBox6.Text 
                + "', PostCode= '" + textBox7.Text + "', Email= '" + textBox8.Text + "', PhoneNum= '" 
                + textBox9.Text + "', Password= '" + textBox10.Text + "', AdminStatus= '" + textBox11.Text 
                + "' WHERE ID = " + int.Parse(label12.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Zaaktualizowano użytkownika");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
