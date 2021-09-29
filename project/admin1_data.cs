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
    public partial class admin1_data : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public admin1_data()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string admin1_id = textBox7.Text;
                string first1_name = textBox1.Text;
                string last1_name = textBox2.Text;
                string address1 = textBox3.Text;
                string contact1_no = textBox4.Text;
                string male1;
                string female1;
                string custom1;
                string email1 = textBox5.Text;
                string password = textBox6.Text;
                string query = "Insert into admin (Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password) values (@parameter_Admin_id,@parameter_First_Name,@parameter_Last_Name,@parameter_Address,@parameter_Contact_No,@parameter_Gender,@parameter_Email,@parameter_password)";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Admin_id",admin1_id);
                cmd.Parameters.AddWithValue("@parameter_First_Name", first1_name);
                cmd.Parameters.AddWithValue("@parameter_Last_Name", last1_name);
                cmd.Parameters.AddWithValue("@parameter_Address", address1);
                cmd.Parameters.AddWithValue("@parameter_Contact_No", contact1_no);
                if(male_select.Checked==true)
                {
                    male1 = male_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender",male1);
                }
                else if(female_select.Checked==true)
                {
                    female1 = female_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", female1);
                }
                else
                {
                    custom1 = custom_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", custom1);
                }
                cmd.Parameters.AddWithValue("@parameter_Email", email1);
                cmd.Parameters.AddWithValue("@parameter_password",password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Canteen Management");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                canteen.Close();
            }
            Displaydata();
        }
        private void Displaydata()
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
                foreach(DataRow dataRow in dt.Rows)
                {
                    sn++;
                    // Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
                    Admin_record.Rows.Add(sn, dataRow["Admin_id"], dataRow["First_Name"], dataRow["Last_Name"], dataRow["Address"], dataRow["Contact_No"], dataRow["Gender"], dataRow["Email"], dataRow["password"],"Edit");
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

        private void admin1_data_Load(object sender, EventArgs e)
        {
            Displaydata();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                if (Admin_record.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in Admin_record.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Admin_id"].Value);
                        string query = "Delete from admin where Admin_id=@parameter_Admin_id";
                        SqlCommand cmd = new SqlCommand(query, canteen);
                        cmd.Parameters.AddWithValue("@parameter_Admin_id", id);
                        cmd.ExecuteNonQuery();
                        Admin_record.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                    Displaydata();
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

        private void Admin_record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==Admin_record.Columns["Action"].Index)
            {
                string admin2_id = Admin_record.CurrentRow.Cells["Admin_Id"].Value.ToString();
                string first2_name = Admin_record.CurrentRow.Cells["First_name"].Value.ToString();
                string last2_name = Admin_record.CurrentRow.Cells["Last_name"].Value.ToString();
                string address2 = Admin_record.CurrentRow.Cells["Address"].Value.ToString();
                string contact2_no =Admin_record.CurrentRow.Cells["Contact_no"].Value.ToString();
                string gender2 = Admin_record.CurrentRow.Cells["Gender"].Value.ToString();
                string email2 = Admin_record.CurrentRow.Cells["Email"].Value.ToString();
                string password = Admin_record.CurrentRow.Cells["Password"].Value.ToString();
     
                textBox7.Text = admin2_id;
                textBox1.Text = first2_name;
                textBox2.Text = last2_name;
                textBox3.Text = address2;
                textBox4.Text = contact2_no;
                if(gender2 == "Male")
                {
                    male_select.Select();
                }
                else if(gender2 == "Female")
                {
                    female_select.Select();
                }
                else
                {
                    custom_select.Select();
                }
                textBox5.Text = email2;
                textBox6.Text = password;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string admin1_id = textBox7.Text;
                string first1_name = textBox1.Text;
                string last1_name = textBox2.Text;
                string address1 = textBox3.Text;
                string contact1_no = textBox4.Text;
                string male1;
                string female1;
                string custom1;
                string email1 = textBox5.Text;
                string password = textBox6.Text;
                string query = "Update admin set Admin_id=@parameter_Admin_id,First_Name=@parameter_First_Name,Last_Name=@parameter_Last_Name,Address=@parameter_Address,Contact_No=@parameter_Contact_No,Gender=@parameter_Gender,Email=@parameter_Email,password=@parameter_password where Admin_id=@parameter_Admin_id";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Admin_id", admin1_id);
                cmd.Parameters.AddWithValue("@parameter_First_Name", first1_name);
                cmd.Parameters.AddWithValue("@parameter_Last_Name", last1_name);
                cmd.Parameters.AddWithValue("@parameter_Address", address1);
                cmd.Parameters.AddWithValue("@parameter_Contact_No", contact1_no);
                if (male_select.Checked == true)
                {
                    male1 = male_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", male1);
                }
                else if (female_select.Checked == true)
                {
                    female1 = female_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", female1);
                }
                else
                {
                    custom1 = custom_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", custom1);
                }
                cmd.Parameters.AddWithValue("@parameter_Email", email1);
                cmd.Parameters.AddWithValue("@parameter_password", password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Canteen Management");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
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
            Displaydata();
        }
    }
}
