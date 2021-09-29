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
    public partial class food_design : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public food_design()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int a1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (momo_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
               // int i=0;
                a1++;
                momo_display.Text = a1.ToString();
            }
            try
            {
                canteen.Open();


                string price=GetFoodPrice("Momo",momo_box.Text);
                int price2 = int.Parse(price);


                string food1_name = label1.Text;
                string Type1 = momo_box.Text;
                string Quantity1 = momo_display.Text;
                int Quantity2 = int.Parse(Quantity1);
                int total1 = price2 * Quantity2;
                string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_food", food1_name);
                cmd.Parameters.AddWithValue("@parameter_Type", Type1);
                cmd.Parameters.AddWithValue("@parameter_Quantity", Quantity1); 
                cmd.Parameters.AddWithValue("@parameter_Price",total1);
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

        private string GetFoodPrice(string foodname, string type)
        {
            string query2 = "Select top(1) Price from food where Food_Name='"+foodname+"' and type='"+type+"'";
            SqlCommand cmd2 = new SqlCommand(query2, canteen);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            var price = dt2.Rows[0].ItemArray[0].ToString();
            return price;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value1 = momo_display.Text;
            int value2 = int.Parse(value1);
            if (value2 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a1--;
                momo_display.Text = a1.ToString();
            }

        }


        private void momo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            a1 = 0;
            momo_display.Text = "0";
            try
            {
                canteen.Open();


               // string price = GetFoodPrice("Momo", momo_box.Text);
                if (momo_box.SelectedItem == null)
                {
                    momo_price.Text = 0.ToString();
                }
                else 
                {
                    string price = GetFoodPrice("Momo", momo_box.Text);
                    momo_price.Text = price;
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
    }
}
