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
    public partial class admin1_data : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public admin1_data()
        {
            InitializeComponent();
          //  datagridcustomize();
        }

       
        private void Save_Click(object sender, EventArgs e)//add admin data
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
                string file_name1 = "";
                String path1 = "";
                if (openFileDialog!=null)
                {
                    if(File.Exists(openFileDialog.FileName))
                    {
                        file_name1 = Path.GetFileName(openFileDialog.FileName);
                         path1 = Application.StartupPath + "\\AdminPhoto\\" + file_name1;
                        if(!Directory.Exists(Application.StartupPath + "\\AdminPhoto\\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\AdminPhoto\\");
                        }
                        File.Copy(openFileDialog.FileName, path1);
                    }
                }
               // String path = Application.StartupPath + "\\AdminPhoto";
               
                string query = "Insert into admin (Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password,Admin_Photo) values (@parameter_Admin_id,@parameter_First_Name,@parameter_Last_Name,@parameter_Address,@parameter_Contact_No,@parameter_Gender,@parameter_Email,@parameter_password,@parameter_Admin_Photo)";
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
                cmd.Parameters.AddWithValue("@parameter_Admin_Photo", path1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Canteen Management");
                empty();
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
                   // Address,Contact_No,Gender,Email,password
                       sn++;
                    // Admin_id,First_Name,Last_Name,Address,Contact_No,Gender,Email,password
                    Admin_record.Rows.Add(sn, dataRow["Admin_id"], dataRow["First_Name"],dataRow["Last_Name"],dataRow["Gender"],"Edit",dataRow["Address"],dataRow["Contact_No"],dataRow["Email"],dataRow["password"],dataRow["Admin_Photo"]);
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

        private void Remove_Click(object sender, EventArgs e)//remove data
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
                    MessageBox.Show("Please select row to delete", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.ColumnIndex == Admin_record.Columns["Action"].Index)
            {
                string admin2_id = Admin_record.CurrentRow.Cells["Admin_Id"].Value.ToString();
                string first2_name = Admin_record.CurrentRow.Cells["First_name"].Value.ToString();
                string last2_name = Admin_record.CurrentRow.Cells["Last_name"].Value.ToString();
                string address2 = Admin_record.CurrentRow.Cells["Address"].Value.ToString();
                string contact2_no = Admin_record.CurrentRow.Cells["Contact_no"].Value.ToString();
                string gender2 = Admin_record.CurrentRow.Cells["Gender"].Value.ToString();
                string email2 = Admin_record.CurrentRow.Cells["Email"].Value.ToString();
                string password = Admin_record.CurrentRow.Cells["Password"].Value.ToString();
                string adminPhoto = Admin_record.CurrentRow.Cells["Admin_photo"].Value.ToString();

                textBox7.Text = admin2_id;
                textBox1.Text = first2_name;
                textBox2.Text = last2_name;
                textBox3.Text = address2;
                textBox4.Text = contact2_no;
                if (gender2 == "Male")
                {
                    male_select.Select();
                }
                else if (gender2 == "Female")
                {
                    female_select.Select();
                }
                else
                {
                    custom_select.Select();
                }
                textBox5.Text = email2;
                textBox6.Text = password;
                // admin_photo1.Image = Image.FromFile(adminPhoto);
                if (adminPhoto != null && adminPhoto != "")
                {
                    admin_photo1.Image = Image.FromFile(adminPhoto);
                }
                else
                {
                    admin_photo1.Image = null;
                }
            }
            else
            {

                string admin3_id = Admin_record.CurrentRow.Cells["Admin_Id"].Value.ToString();
                string first3_name = Admin_record.CurrentRow.Cells["First_name"].Value.ToString();
                 string last3_name = Admin_record.CurrentRow.Cells["Last_name"].Value.ToString();
                string address3 = Admin_record.CurrentRow.Cells["Address"].Value.ToString();
                string contact3_no = Admin_record.CurrentRow.Cells["Contact_no"].Value.ToString();
                string gender3 = Admin_record.CurrentRow.Cells["Gender"].Value.ToString();
                string email3 = Admin_record.CurrentRow.Cells["Email"].Value.ToString();
                string password3 = Admin_record.CurrentRow.Cells["Password"].Value.ToString();
                string adminPhoto2 = Admin_record.CurrentRow.Cells["Admin_photo"].Value.ToString();

                textBox8.Text = admin3_id;
                textBox9.Text = first3_name;
                textBox15.Text = last3_name;
                textBox10.Text = address3;
                textBox11.Text = contact3_no;
                if (gender3 == "Male")
                {
                    textBox12.Text = "Male";
                }
                else if (gender3 == "Female")
                {
                    textBox12.Text = "Female";
                }
                else
                {
                    textBox12.Text = "Custom";
                }
                textBox13.Text = email3;
                textBox14.Text = password3;
                //  Admin_photo2.Image = Image.FromFile(adminPhoto2);
                if (adminPhoto2 != null && adminPhoto2 != "")
                {
                    Admin_photo2.Image = Image.FromFile(adminPhoto2);
                }
                else
                {
                    Admin_photo2.Image = null;
                }

            }
        }

        private void Update_Click(object sender, EventArgs e)//update
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
                string file_name3 = "";
                String path3 = "";
                if (openFileDialog != null)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        file_name3 = Path.GetFileName(openFileDialog.FileName);
                        path3 = Application.StartupPath + "\\AdminPhoto\\" + file_name3;
                        if (!Directory.Exists(Application.StartupPath + "\\AdminPhoto\\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\AdminPhoto\\");
                        }
                        File.Copy(openFileDialog.FileName, path3);
                    }
                }
                    string query = "Update admin set Admin_id=@parameter_Admin_id,First_Name=@parameter_First_Name,Last_Name=@parameter_Last_Name,Address=@parameter_Address,Contact_No=@parameter_Contact_No,Gender=@parameter_Gender,Email=@parameter_Email,password=@parameter_password,Admin_Photo=@parameter_Admin_Photo where Admin_id=@parameter_Admin_id";
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
                cmd.Parameters.AddWithValue("@parameter_Admin_Photo", path3);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully", "Canteen Management");
                empty();





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
        private void empty()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            male_select.Checked = false;
            female_select.Checked = false;
            custom_select.Checked = false;
            admin_photo1.Image = null;
        }

        private void Admin_record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
       // private object itemviewer;
      //  private object iteamviewer;

        private void button1_Click(object sender, EventArgs e)//insert image
        {
           // openFileDialog.Filter = "*|Images,*.jpeg; |*.jpg; |*.png";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                admin_photo1.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Closed File Dialog", "Canteen Management ");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            empty();
        }
    }
}
