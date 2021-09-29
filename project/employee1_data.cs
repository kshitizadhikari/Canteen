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
    public partial class employee1_data : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public employee1_data()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string employee4_id = textBox7.Text;
                string first4_name = textBox1.Text;
                string last4_name = textBox2.Text;
                string address4 = textBox3.Text;
                string contact4_no = textBox4.Text;
                string male4;
                string female4;
                string custom4;
                string type4 = comboBox1.Text;
                string shift4 =comboBox2.Text;
                string salary4 = textBox6.Text;
                string query = "Update employee set Employee_ID=@parameter_Employee_Id,First_Name=@parameter_First_Name,Last_Name=@parameter_Last_Name,Address=@parameter_Address,Contact_No=@parameter_Contact_No,Gender=@parameter_Gender,Employee_Type=@parameter_Employee_Type,Shift=@parameter_Shift,Salary=@parameter_Salary where Employee_Id=@parameter_Employee_Id";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@parameter_Employee_id", employee4_id);
                cmd.Parameters.AddWithValue("@parameter_First_Name", first4_name);
                cmd.Parameters.AddWithValue("@parameter_Last_Name", last4_name);
                cmd.Parameters.AddWithValue("@parameter_Address", address4);
                cmd.Parameters.AddWithValue("@parameter_Contact_No", contact4_no);
                if (male_select.Checked == true)
                {
                    male4 = male_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", male4);
                }
                else if (female_select.Checked == true)
                {
                    female4 = female_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", female4);
                }
                else
                {
                    custom4 = custom_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", custom4);
                }
                cmd.Parameters.AddWithValue("@parameter_Employee_Type", type4);
                cmd.Parameters.AddWithValue("@parameter_Shift", shift4);
                cmd.Parameters.AddWithValue("@parameter_Salary", salary4);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Canteen Management");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            Displaydata1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                if (Employee_record.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in Employee_record.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Employee_Id"].Value);
                        string query = "Delete from employee where Employee_Id=@parameter_Employee_Id";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_Employee_Id", id);
                        cmd.ExecuteNonQuery();
                        Employee_record.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                    Displaydata1();
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
                connect.Close();
            }
        }

        private void Displaydata1()
        {
            try
            {
                connect.Open();
                string query = "Select * from employee";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Employee_record.Rows.Clear();
                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    // Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
                    Employee_record.Rows.Add(sn, dataRow["Employee_Id"], dataRow["First_Name"], dataRow["Last_Name"], dataRow["Address"], dataRow["Contact_No"], dataRow["Gender"], dataRow["Employee_Type"], dataRow["Shift"],dataRow["Salary"], "Edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string employee5_id = textBox7.Text;
                string first5_name = textBox1.Text;
                string last5_name = textBox2.Text;
                string address5 = textBox3.Text;
                string contact5_no = textBox4.Text;
                string male5;
                string female5;
                string custom5;
                string employee5_type = comboBox1.Text;
                string shift5 = comboBox2.Text;
                string salary5 = textBox6.Text;
                string query = "Insert into employee (Employee_Id,First_Name,Last_Name,Address,Contact_No,Gender,Employee_Type,Shift,Salary) values (@parameter_Employee_Id,@parameter_First_Name,@parameter_Last_Name,@parameter_Address,@parameter_Contact_No,@parameter_Gender,@parameter_Employee_Type,@parameter_Shift,@parameter_Salary)";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@parameter_Employee_Id", employee5_id);
                cmd.Parameters.AddWithValue("@parameter_First_Name", first5_name);
                cmd.Parameters.AddWithValue("@parameter_Last_Name", last5_name);
                cmd.Parameters.AddWithValue("@parameter_Address", address5);
                cmd.Parameters.AddWithValue("@parameter_Contact_No", contact5_no);
                if (male_select.Checked == true)
                {
                    male5 = male_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", male5);
                }
                else if (female_select.Checked == true)
                {
                    female5 = female_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", female5);
                }
                else
                {
                    custom5 = custom_select.Text;
                    cmd.Parameters.AddWithValue("@parameter_Gender", custom5);
                }
                cmd.Parameters.AddWithValue("@parameter_Employee_Type", employee5_type);
                cmd.Parameters.AddWithValue("@parameter_Shift", shift5);
                cmd.Parameters.AddWithValue("@parameter_Salary", salary5);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Canteen Management");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            Displaydata1();
        }

        private void employee1_data_Load(object sender, EventArgs e)
        {
            Displaydata1();
        }

        private void Employee_record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==Employee_record.Columns["Action"].Index)
            {
                string employee3_id = Employee_record.CurrentRow.Cells["Employee_Id"].Value.ToString();
                string first3_name = Employee_record.CurrentRow.Cells["First_name"].Value.ToString();
                string last3_name = Employee_record.CurrentRow.Cells["Last_name"].Value.ToString();
                string address3 = Employee_record.CurrentRow.Cells["Address"].Value.ToString();
                string contact3_no = Employee_record.CurrentRow.Cells["Contact_no"].Value.ToString();
                string gender3 = Employee_record.CurrentRow.Cells["Gender"].Value.ToString();
                string Type3= Employee_record.CurrentRow.Cells["Type"].Value.ToString();
                string Shift3= Employee_record.CurrentRow.Cells["Shift"].Value.ToString();
                string Salary3 = Employee_record.CurrentRow.Cells["Salary"].Value.ToString();

                textBox7.Text = employee3_id;
                textBox1.Text = first3_name;
                textBox2.Text = last3_name;
                textBox3.Text = address3;
                textBox4.Text = contact3_no;
                if (gender3 == "Male")
                {
                    male_select.Select();
                }
                else if (gender3 == "Female")
                {
                    female_select.Select();
                }
                else
                {
                    custom_select.Select();
                }
                comboBox1.Text = Type3;
                comboBox2.Text = Shift3;
                textBox6.Text = Salary3;
            }
        }
    }
}
