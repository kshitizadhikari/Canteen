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

namespace project
{

    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select * from admin where Admin_Id='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            if(DT.Rows.Count ==   1)
            {

                Admin sc = new Admin();
                this.Hide();
                sc.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Admin id or password");
            }
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_mode sc = new Select_mode();
            this.Hide();
            sc.Show();
        }
    }
}
