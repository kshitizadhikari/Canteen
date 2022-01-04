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
                string food_id1 = Food_data.CurrentRow.Cells["Food_id"].Value.ToString();
                string food_name1 = Food_data.CurrentRow.Cells["Food_Name"].Value.ToString();
                string food_type1 = Food_data.CurrentRow.Cells["Type"].Value.ToString();
                string food_quantity1 = Food_data.CurrentRow.Cells["Quantity"].Value.ToString();
                string food_price1 = Food_data.CurrentRow.Cells["Price"].Value.ToString();
                textBox1.Text = food_name1;
                textBox2.Text = food_type1;
                textBox3.Text = food_quantity1;
                textBox4.Text = food_price1;
                textBox5.Text = food_id1;

            }
        }

        private void Change1_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string food_id1 = textBox5.Text;
                string food_name1 = textBox1.Text;
                string food_type1 = textBox2.Text;
                string food_quantity1 = textBox3.Text;
                string food_price1 = textBox4.Text;
                string query = "Update food set Food_id=@parameter_Food_id,Food_Name=@parameter_Food_Name,Type=@parameter_Type,Quantity=@Parameter_Quantity,Price=@parameter_Price where Food_id=@parameter_Food_id";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Food_id", food_id1);
                cmd.Parameters.AddWithValue("@parameter_Food_Name", food_name1);
                cmd.Parameters.AddWithValue("@parameter_Type", food_type1);
                cmd.Parameters.AddWithValue("@parameter_Quantity", food_quantity1);
                cmd.Parameters.AddWithValue("@parameter_Price", food_price1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Canteen Management");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
         
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

        private void save_food_Click(object sender, EventArgs e)
        {

            try
            {
                canteen.Open();
                string Food1_id = textBox5.Text;
                string Food1_name = textBox1.Text;
                string Food1_type = textBox2.Text;
                string Food1_quantity = textBox3.Text;
                string Food1_price = textBox4.Text;
                string query = "Insert into food (Food_id,Food_Name,Type,Quantity,Price) values (@parameter_Food_id,@parameter_Food_Name,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Food_id", Food1_id);
                cmd.Parameters.AddWithValue("@parameter_Food_Name",Food1_name);
                cmd.Parameters.AddWithValue("@parameter_Type", Food1_type);
                cmd.Parameters.AddWithValue("@parameter_Quantity",Food1_quantity);
                cmd.Parameters.AddWithValue("@parameter_Price", Food1_price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Canteen Management");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

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

        private void delete_food_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                if (Food_data.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in Food_data.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Food_id"].Value);
                        string query = "Delete from food where Food_id=@parameter_Food_id";
                        SqlCommand cmd = new SqlCommand(query, canteen);
                        cmd.Parameters.AddWithValue("@parameter_Food_id", id);
                        cmd.ExecuteNonQuery();
                        Food_data.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                    displayfood();
                }

                else
                {
                    MessageBox.Show("Please select row to delete", "Canteen Management");
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
