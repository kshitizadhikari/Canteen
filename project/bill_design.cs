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
                foreach (DataRow dataRow in dt2.Rows)
                {
                    var price = dt2.Rows[0].ItemArray[0].ToString();
                    int price2 = int.Parse(price);
                    Total = Total + price2;
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
            try
            {
                canteen.Open();
                string query = "Delete from food_order";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
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
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //for actual document 
            int height = food_bill.Height;
            food_bill.Height = food_bill.RowCount * food_bill.RowTemplate.Height * 2;
            bmp = new Bitmap(food_bill.Width, food_bill.Height);
            food_bill.DrawToBitmap(bmp, new Rectangle(0, 0, food_bill.Width, food_bill.Height));
            food_bill.Height = height;
            e.Graphics.DrawImage(bmp, 0, 0);
            //printPreviewDialog1.ShowDialog();
            //e.Graphics.DrawString("Print Page", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void Print_box_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        }
    }
}
