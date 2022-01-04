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
    public partial class Drink_information : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public Drink_information()
        {
            InitializeComponent();
        }

        private void save_bakery_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string Drink1_id = textBox5.Text;
                string Drink1_name = textBox9.Text;
                string Drink1_type = textBox8.Text;
                string Drink1_quantity = textBox7.Text;
                string Drink1_price = textBox6.Text;
                string query = "Insert into Drink (Drink_id,Drink_Name,Type,Quantity,Price) values (@parameter_Drink_id,@parameter_Drink_Name,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Drink_id", Drink1_id);
                cmd.Parameters.AddWithValue("@parameter_Drink_Name", Drink1_name);
                cmd.Parameters.AddWithValue("@parameter_Type", Drink1_type);
                cmd.Parameters.AddWithValue("@parameter_Quantity", Drink1_quantity);
                cmd.Parameters.AddWithValue("@parameter_Price", Drink1_price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Canteen Management");
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
                canteen.Close();
            }
            displaydrink();
        }
        private void displaydrink()
        {
            try
            {
                canteen.Open();
                string query = "Select * from Drink ";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                drink_data.Rows.Clear();
                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    drink_data.Rows.Add(sn, dataRow["Drink_id"], dataRow["Drink_Name"], dataRow["Type"], dataRow["Quantity"], dataRow["Price"], "Edit");
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

        private void delete_drink_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                if (drink_data.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in drink_data.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Drink_id"].Value);
                        string query = "Delete from Drink where Drink_id=@parameter_Drink_id";
                        SqlCommand cmd = new SqlCommand(query, canteen);
                        cmd.Parameters.AddWithValue("@parameter_Drink_id", id);
                        cmd.ExecuteNonQuery();
                        drink_data.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                    displaydrink();
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

        private void Drink_information_Load(object sender, EventArgs e)
        {
            displaydrink();
        }

        private void drink_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == drink_data.Columns["Action"].Index)
            {
                string drink_id1 = drink_data.CurrentRow.Cells["Drink_id"].Value.ToString();
                string drink_name1 = drink_data.CurrentRow.Cells["Drink_Name"].Value.ToString();
                string drink_type1 = drink_data.CurrentRow.Cells["Type"].Value.ToString();
                string drink_quantity1 = drink_data.CurrentRow.Cells["Quantity"].Value.ToString();
                string drink_price1 = drink_data.CurrentRow.Cells["Price"].Value.ToString();
                textBox9.Text = drink_name1;
                textBox8.Text = drink_type1;
                textBox7.Text = drink_quantity1;
                textBox6.Text = drink_price1;
                textBox5.Text = drink_id1;

            }
        }

        private void Change_drink_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string drink1_id = textBox5.Text;
                string drink1_name = textBox9.Text;
                string drink1_Type = textBox8.Text;
                string drink1_Quantity = textBox7.Text;
                string drink1_Price = textBox6.Text;
                string query = "Update Drink set Drink_id=@parameter_Drink_id,Drink_Name=@parameter_Drink_Name,Type=@parameter_Type,Quantity=@parameter_Quantity,Price=@parameter_Price where Drink_id=@parameter_Drink_id";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Drink_id", drink1_id);
                cmd.Parameters.AddWithValue("@parameter_Drink_Name", drink1_name);
                cmd.Parameters.AddWithValue("@parameter_Type", drink1_Type);
                cmd.Parameters.AddWithValue("@parameter_Quantity", drink1_Quantity);
                cmd.Parameters.AddWithValue("@parameter_Price", drink1_Price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Canteen Management");
                textBox9.Text = "";
                textBox8.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen.Close();
            }
            displaydrink();
        }

        private void drink_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
