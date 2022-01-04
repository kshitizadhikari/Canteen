using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace project
{
    public partial class Admin : Form
    {
        //SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        
        public Admin()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Select_mode sc = new Select_mode();
            this.Hide();
            sc.Show();
           
        }
        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           admin1_data1.BringToFront();
            panel5.Top = button1.Top;
            panel5.Height = button1.Height;

            // Displaydata();
          
           


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             employee1_data1.BringToFront();
            admin1_data1.SendToBack();
            panel5.Top = button2.Top;
            panel5.Height = button2.Height;

        }

        private void admin1_data1_Load(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
          //  food1_record1.BringToFront();
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
          food_information1.BringToFront();
            panel5.Top = button3.Top;
            panel5.Height = button3.Height;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drink_information1.BringToFront();
            panel5.Top = button5.Top;
            panel5.Height = button5.Height;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bakery_information1.BringToFront();
            panel5.Top = button6.Top;
            panel5.Height = button6.Height;
        }

        private void admin1_data1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin1_data1_Load_2(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee1_data1_Load(object sender, EventArgs e)
        {

        }

        private void admin1_data1_Load_3(object sender, EventArgs e)
        {

        }
        /*private void Displaydata()
{
try
{
canteen.Open();
string query = "Select * from admin";
SqlCommand cmd = new SqlCommand(query, canteen);
SqlDataAdapter sda = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sda.Fill(dt);
Admin_record.Rows.Clear();
int sn = 0;
foreach (DataRow dataRow in dt.Rows)
{
sn++;
// Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
Admin_record.Rows.Add(sn, dataRow["Admin_id"], dataRow["First_Name"], dataRow["Last_Name"], dataRow["Address"], dataRow["Contact_No"], dataRow["Gender"], dataRow["Email"], dataRow["password"], "Edit");
}
}
catch (Exception ex)
{
MessageBox.Show(ex.ToString());
}
finally
{
canteen.Close();
}
}*/
    }
}
