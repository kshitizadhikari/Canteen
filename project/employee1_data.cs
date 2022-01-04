using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                string file_name4 = "";
                String path4 = "";
                if (openFileDialog != null)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        file_name4 = Path.GetFileName(openFileDialog.FileName);
                        path4 = Application.StartupPath + "\\EmployeePhoto\\" + file_name4;
                        if (!Directory.Exists(Application.StartupPath + "\\EmployeePhoto\\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\EmployeePhoto\\");
                        }
                        File.Copy(openFileDialog.FileName, path4);
                    }
                }
                string query = "Update employee set Employee_ID=@parameter_Employee_Id,First_Name=@parameter_First_Name,Last_Name=@parameter_Last_Name,Address=@parameter_Address,Contact_No=@parameter_Contact_No,Gender=@parameter_Gender,Employee_Type=@parameter_Employee_Type,Shift=@parameter_Shift,Salary=@parameter_Salary,Employee_Photo=@Employee_Photo where Employee_Id=@parameter_Employee_Id";
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
                cmd.Parameters.AddWithValue("@parameter_Employee_Photo", path4);
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
                    Employee_record.Rows.Add(sn, dataRow["Employee_Id"], dataRow["First_Name"], dataRow["Last_Name"], dataRow["Gender"], "Edit" ,dataRow["Address"], dataRow["Contact_No"], dataRow["Employee_Type"], dataRow["Shift"],dataRow["Salary"], dataRow["Employee_Photo"]);
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
                String path1 = "";
                string file_name1 = "";

                
                if (openFileDialog != null)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        file_name1 = Path.GetFileName(openFileDialog.FileName);
                        path1 = Application.StartupPath + "\\EmployeePhoto\\" + file_name1;
                        if (!Directory.Exists(Application.StartupPath + "\\EmployeePhoto\\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\EmployeePhoto\\");
                        }
                        File.Copy(openFileDialog.FileName, path1);
                    }
                }
                string query = "Insert into employee (Employee_Id,First_Name,Last_Name,Address,Contact_No,Gender,Employee_Type,Shift,Salary,Employee_Photo) values (@parameter_Employee_Id,@parameter_First_Name,@parameter_Last_Name,@parameter_Address,@parameter_Contact_No,@parameter_Gender,@parameter_Employee_Type,@parameter_Shift,@parameter_Salary,@Parameter_Employee_Photo)";
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
                cmd.Parameters.AddWithValue("@parameter_Employee_Photo", path1);
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
                string employeePhoto3 = Employee_record.CurrentRow.Cells["Employee_photo"].Value.ToString();
                

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
                employee_photo1.Image = Image.FromFile(employeePhoto3);
            }
            string employee4_id = Employee_record.CurrentRow.Cells["Employee_Id"].Value.ToString();
            string first4_name = Employee_record.CurrentRow.Cells["First_name"].Value.ToString();
        //    string last4_name = Employee_record.CurrentRow.Cells["Last_name"].Value.ToString();
            string address4 = Employee_record.CurrentRow.Cells["Address"].Value.ToString();
            string contact4_no = Employee_record.CurrentRow.Cells["Contact_no"].Value.ToString();
            string gender4 = Employee_record.CurrentRow.Cells["Gender"].Value.ToString();
            string Type4 = Employee_record.CurrentRow.Cells["Type"].Value.ToString();
            string Shift4 = Employee_record.CurrentRow.Cells["Shift"].Value.ToString();
            string Salary4 = Employee_record.CurrentRow.Cells["Salary"].Value.ToString();
            string employeePhoto4 = Employee_record.CurrentRow.Cells["Employee_photo"].Value.ToString();


            textBox8.Text = employee4_id;
            textBox9.Text = first4_name;
            //textBox.Text = last3_name;
            textBox10.Text = address4;
            textBox11.Text = contact4_no;
            if (gender4 == "Male")
            {
                textBox12.Text = "Male";
            }
            else if (gender4 == "Female")
            {
                textBox12.Text = "Female";
            }
            else
            {
                textBox12.Text = "Custom";
            }
            textBox13.Text = Type4;
            textBox14.Text = Shift4;
            textBox5.Text = Salary4;
            employee_photo2.Image = Image.FromFile(employeePhoto4);
        }

        private void Employee_record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog.Filter = "Image only . |*jpeg; |*.jpg; |*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                employee_photo1.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Closed File Dialog", "Canteen Management ");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
