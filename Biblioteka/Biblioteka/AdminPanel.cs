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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\libraryDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDbDataSet.Users' table. You can move, or remove it, as needed.
            // this.usersTableAdapter.Fill(this.libraryDbDataSet.Users);

        

            if (Program.loggedUser.AdminStatus == 0)
            {
                addBookButton.Enabled = false;
                addGenreButton.Enabled = false;
                
                addAuthorButton.Enabled = false;
            }

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.button1.Visible = true;
            form2.button2.Visible = false;

        }

        public void addAuthorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tak", "Na pewno chcesz usunąć użytkownika?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\libraryDb.mdf;Integrated Security = True; Connect Timeout = 30"))
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from [Users] where id='" + id + "'";

                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }

                }
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }


      

        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.label12.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form2.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form2.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form2.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form2.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form2.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form2.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            form2.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            form2.textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            form2.textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            form2.textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            form2.textBox11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            form2.Show();
            form2.button2.Visible = true;
            form2.button1.Visible = false;
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Users]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddPublisher().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddGenre().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new AddBook().Show();
        }
    }
}
