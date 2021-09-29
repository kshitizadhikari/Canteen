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
    public partial class Food_information : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public Food_information()
        {
            InitializeComponent();
        }

        private void Food_information_Load(object sender, EventArgs e)
        {
            displayfood();
        }
        private void displayfood()
        {
            try
            {
                canteen.Open();
                string query = "Select * from food ";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Food_data.Rows.Clear();
                int sn = 0;
                foreach(DataRow dataRow in dt.Rows)
                {
                    sn++;
                    Food_data.Rows.Add(sn,dataRow["Food_id"],dataRow["Food_Name"],dataRow["Type"],dataRow["Quantity"],dataRow["Price"],"Edit");
                }
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

        private void Food_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==Food_data.Columns["Action"].Index)
            {
                string food_name1 = Food_data.CurrentRow.Cells["Food_id"].Value.ToString();
                string food_type1 = Food_data.CurrentRow.Cells["Type"].Value.ToString();
                string food_quantity1 = Food_data.CurrentRow.Cells["Quantity"].Value.ToString();
                string food_price1 = Food_data.CurrentRow.Cells["Price"].Value.ToString();
                textBox1.Text = food_name1;
                textBox2.Text = food_type1;
                textBox3.Text = food_quantity1;
                textBox4.Text = food_price1;

            }
        }

        private void Change1_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string food_id2 = textBox1.Text;
                string food_price2 = textBox4.Text;
                if (textBox1.Text == food_id2)
                {
                    string query = "Update food set Food_id=@parameter_Food_id,Price=@parameter_Price where Food_id=@parameter_Food_id";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Food_id", food_id2);
                    cmd.Parameters.AddWithValue("@parameter_Price", food_price2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully", "Canteen Management");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {

                    MessageBox.Show("Only food price can be change", "Canteen Management");
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
            displayfood();
        
        }
    }
}
