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
    public partial class bill_design : UserControl
    {
         SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public bill_design()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int Total = 0;
                canteen.Open();
                string query = "Select Price from food_order";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);

                foreach (DataRow dataRow in dt2.Rows)
                {
                    string price = dt2.Rows[i].ItemArray[0].ToString();
                    int price2 = int.Parse(price);
                    Total = Total + price2;
                    i++;
                }
                total_box.Text = Total.ToString();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        } 
        private void cancel()
        {
            try
            {
                canteen.Open();
                string query = "Delete from food_order";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen.Close();

            }
            Displaydata1();
          //  food_design1.momo_display.Text = "0";
            Select_mode sc = new Select_mode();
            this.Parent.Dispose();
            sc.Show();
        }
        private void bill_design_Load(object sender, EventArgs e)
        {
            Displaydata1();
        }
        private void Displaydata1()
        {
            try
            {
                canteen.Open();
                string query = "Select * from food_order";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                food_bill.Rows.Clear();
                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    // Address,Contact_No,Gender,Email,password
                    sn++;
                    // Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
                    food_bill.Rows.Add(sn, dataRow["food"], dataRow["Type"], dataRow["Quantity"], dataRow["Price"]);
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
        }
        private void button1_Click(object sender, EventArgs e)//food total
        {
            try
            {
                int Total = 0;
                canteen.Open();
                string query = "Select Price from food_order";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);
                int i = 0;
                foreach (DataRow dataRow in dt2.Rows)
                {
                    var price = dt2.Rows[i].ItemArray[0].ToString();
                    int price2 = int.Parse(price);
                    Total = Total + price2;
                    i++;
                }
                total_box.Text = Total.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cancel();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //for actual document 
            int height = food_bill.Height;
            food_bill.Height = food_bill.RowCount * food_bill.RowTemplate.Height * 2;
            bmp = new Bitmap(food_bill.Width, food_bill.Height);
            food_bill.DrawToBitmap(bmp, new Rectangle(0, 0, food_bill.Width, food_bill.Height));
            food_bill.Height = height;
            e.Graphics.DrawImage(bmp, 49, 219);
            //printPreviewDialog1.ShowDialog();
            e.Graphics.DrawString("Resturant Management", new Font("Arial", 22, FontStyle.Bold), Brushes.OrangeRed, new Point(203, 14));
            e.Graphics.DrawString("Receipt-Bill", new Font("Arial", 12, FontStyle.Bold), Brushes.OrangeRed, new Point(286, 54));
            e.Graphics.DrawString("Name:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(62, 144));
            e.Graphics.DrawString("Address:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(45, 183));
            e.Graphics.DrawString("Contact No:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(344, 144));
            e.Graphics.DrawString("Date:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(393, 181));
            e.Graphics.DrawString("Total:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(464, 468));
            e.Graphics.DrawString("Discount:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(430, 504));
            e.Graphics.DrawString("Grand Total:-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(397, 535));
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(118, 141));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(118, 179));
            e.Graphics.DrawString(textBox4.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(440, 140));
            e.Graphics.DrawString(textBox7.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(440, 177));
            e.Graphics.DrawString(total_box.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(524, 465));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(524, 501));
            e.Graphics.DrawString(textBox8.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(524, 538));
            cancel();

        }

        private void Print_box_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        }

        private void grand_total_Click(object sender, EventArgs e)//final total
        {
            string discount1 = textBox2.Text;
            int discount2 = int.Parse(discount1);
            string total1 = total_box.Text;
            int total2 = int.Parse(total1);
            int grand = (total2 - discount2);
            textBox8.Text = grand.ToString();


        }
    }
}
