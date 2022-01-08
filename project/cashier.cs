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
    public partial class cashier : Form
    {
         SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public cashier()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bar2.Top = button5.Top;
            bar2.Height = button5.Height;
            Select_mode sc = new Select_mode();
            this.Hide();
            sc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            food_design1.BringToFront();
            bar2.Top = button1.Top;
            bar2.Height = button1.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drinks_design1.BringToFront();
            bar2.Top = button2.Top;
            bar2.Height = button2.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             bakery_design1.BringToFront();
            bar2.Top = button3.Top;
            bar2.Height = button3.Height;
        }

        private void button4_Click(object sender, EventArgs e)
         {
           /* bar2.Top = button4.Top;
             bar2.Height = button4.Height;
             canteen.Open();
             string query = "Select * from food_order";
             SqlCommand cmd = new SqlCommand(query, canteen);
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             bill_design1.food_bill.Rows.Clear();
             int sn = 0;
             foreach (DataRow dataRow in dt.Rows)
             {
                 // Address,Contact_No,Gender,Email,password
                 sn++;
                 // Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
                 bill_design1.food_bill.Rows.Add(sn, dataRow["food"], dataRow["Type"], dataRow["Quantity"], dataRow["Price"]);
             }

             canteen.Close();
             bill_design1.BringToFront();
             try
             {
                 int Total = 0;
                 canteen.Open();
                 string query2 = "Select Price from food_order";
                 SqlCommand cmd2 = new SqlCommand(query2, canteen);
                 SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                 DataTable dt2 = new DataTable();
                 sda2.Fill(dt2);
                 int i = 0;
                 foreach (DataRow dataRow in dt2.Rows)
                 {
                     var price = dt2.Rows[i].ItemArray[0].ToString();
                     int price2 = int.Parse(price);
                     Total = Total + price2;
                     i++;
                 }
                 bill_design1.total_box.Text = Total.ToString();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
             finally
             {
                 canteen.Close();
             }*/
         }

        private void food_design1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void total_display_TextChanged(object sender, EventArgs e)
        {
            //total_display.Text = total_box.Tostring();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           bar2.Top = button4.Top;
            bar2.Height = button4.Height;
            canteen.Open();
            string query = "Select * from food_order";
            SqlCommand cmd = new SqlCommand(query, canteen);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bill_design1.food_bill.Rows.Clear();
            int sn = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                // Address,Contact_No,Gender,Email,password
                sn++;
                // Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
                bill_design1.food_bill.Rows.Add(sn, dataRow["food"], dataRow["Type"], dataRow["Quantity"], dataRow["Price"]);
            }

            canteen.Close();
            bill_design1.BringToFront();
            try
            {
                int Total = 0;
                canteen.Open();
                string query2 = "Select Price from food_order";
                SqlCommand cmd2 = new SqlCommand(query2, canteen);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                int i = 0;
                foreach (DataRow dataRow in dt2.Rows)
                {
                    var price = dt2.Rows[i].ItemArray[0].ToString();
                    int price2 = int.Parse(price);
                    Total = Total + price2;
                    i++;
                }
                bill_design1.total_box.Text = Total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen.Close();
            }
        }

        private void cashier_Load(object sender, EventArgs e)
        {

        }

        /*    private void cashier_Load(object sender, EventArgs e)
            {
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;
                this.Location = new Point(0, 0);
                this.Size = new Size(w, h);
            }*/
    }
}
