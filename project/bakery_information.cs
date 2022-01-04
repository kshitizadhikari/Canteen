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
    public partial class bakery_information : UserControl
    {
        SqlConnection canteen1 = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public bakery_information()
        {
            InitializeComponent();
        }

        private void bakery_information_Load(object sender, EventArgs e)
        {
            displaybakery();
        }
        private void displaybakery()
        {
            try
            {
                canteen1.Open();
                string query = "Select * from Bakery1 ";
                SqlCommand cmd = new SqlCommand(query, canteen1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bakery_data.Rows.Clear();
                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    bakery_data.Rows.Add(sn, dataRow["Bakery_id"], dataRow["Bakery_Name"], dataRow["Type"], dataRow["Quantity"], dataRow["Price"], "Edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                canteen1.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void save_food_Click(object sender, EventArgs e)
        {
            try
            {
                canteen1.Open();
                string bakery1_id = textBox5.Text;
                string bakery1_name = textBox9.Text;
                string bakery1_type = textBox8.Text;
                string bakery1_quantity = textBox7.Text;
                string bakery1_price = textBox6.Text;
                string query = "Insert into Bakery1 (Bakery_id,Bakery_Name,Type,Quantity,Price) values (@parameter_Bakery_id,@parameter_Bakery_Name,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                SqlCommand cmd = new SqlCommand(query, canteen1);
                cmd.Parameters.AddWithValue("@parameter_Bakery_id", bakery1_id);
                cmd.Parameters.AddWithValue("@parameter_Bakery_Name", bakery1_name);
                cmd.Parameters.AddWithValue("@parameter_Type", bakery1_type);
                cmd.Parameters.AddWithValue("@parameter_Quantity", bakery1_quantity);
                cmd.Parameters.AddWithValue("@parameter_Price", bakery1_price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Canteen Management");
                textBox5.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen1.Close();
            }
            displaybakery();
        }

        private void delete_bakery_Click(object sender, EventArgs e)
        {

            try
            {
                canteen1.Open();
                if (bakery_data.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in bakery_data.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Food_id"].Value);
                        string query = "Delete from food where Food_id=@parameter_Food_id";
                        SqlCommand cmd = new SqlCommand(query, canteen1);
                        cmd.Parameters.AddWithValue("@parameter_Food_id", id);
                        cmd.ExecuteNonQuery();
                        bakery_data.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                    displaybakery();
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
                canteen1.Close();
            }
        }

        private void bakery_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bakery_data.Columns["Action"].Index)
            {
                string bakery_id1 = bakery_data.CurrentRow.Cells["Bakery_id"].Value.ToString();
                string bakery_name1 = bakery_data.CurrentRow.Cells["Bakery_Name"].Value.ToString();
                string bakery_type1 = bakery_data.CurrentRow.Cells["Type"].Value.ToString();
                string bakery_quantity1 = bakery_data.CurrentRow.Cells["Quantity"].Value.ToString();
                string bakery_price1 = bakery_data.CurrentRow.Cells["Price"].Value.ToString();
                textBox9.Text = bakery_name1;
                textBox8.Text = bakery_type1;
                textBox7.Text = bakery_quantity1;
                textBox6.Text = bakery_price1;
                textBox5.Text = bakery_id1;

            }
        }

        private void Change_bakery_Click(object sender, EventArgs e)
        {
            try
            {
                canteen1.Open();
                string bakery2_id = textBox5.Text;
                string bakery2_name = textBox9.Text;
                string bakery2_type = textBox8.Text;
                string bakery2_quantity = textBox7.Text;
                string bakery2_price = textBox6.Text;
                string query = "Update Bakery1 set Bakery_id=@parameter_Bakery_id,Bakery_Name=@parameter_Bakery_Name,Type=@parameter_Type,Quantity=@parameter_Quantity,Price=@parameter_Price where Bakery_id=@parameter_Bakery_id";
                SqlCommand cmd = new SqlCommand(query, canteen1);
                cmd.Parameters.AddWithValue("@parameter_Bakery_id", bakery2_id);
                cmd.Parameters.AddWithValue("@parameter_Bakery_Name", bakery2_name);
                cmd.Parameters.AddWithValue("@parameter_Type", bakery2_type);
                cmd.Parameters.AddWithValue("@parameter_Quantity", bakery2_quantity);
                cmd.Parameters.AddWithValue("@parameter_Price", bakery2_price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Canteen Management");
                textBox5.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen1.Close();
            }
            displaybakery();
        }
    }
}
