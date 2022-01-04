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
    public partial class food_dynamic_panel : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public food_dynamic_panel()
        {
            InitializeComponent();
        }

        private void food_dynamic_panel_Load(object sender, EventArgs e)
        {
            try
            {
                canteen.Open();
                string query = "Select Food_Name from food group by Food_Name";
                SqlCommand cmd = new SqlCommand(query, canteen);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int x = 10, y = 10;
                int i = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    string food_name = dataRow["Food_Name"].ToString();
                    string query2 = "Select * from food where Food_Name='" + food_name + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, canteen);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);


                    Panel panel = new Panel();
                    panel.Size = new Size(200, 300);
                    panel.Location = new Point(x, y);
                    panel.BackColor = Color.Red;

                    Label label = new Label();
                    label.Text = food_name;
                    label.Location = new Point(10, 20);
                    panel.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(20, 100);
                    textBox.Location = new Point(10, 100);
                    panel.Controls.Add(textBox);

                    ComboBox comboBox = new ComboBox();
                    comboBox.Size = new Size(30, 100);
                    comboBox.Location = new Point(0, 20);
                    foreach (DataRow dataRow2 in dt2.Rows)
                    {
                        comboBox.Items.Add(dataRow2["Type"].ToString());
                    }
                    panel.Controls.Add(comboBox);

                    Button btn = new Button();
                    btn.Size = new Size(10, 20);
                    btn.Text = "Increse " + i;
                    btn.Location = new Point(50, 100);
                 //   btn.Click += new System.EventHandler(this.Sample_Click);
                    panel.Controls.Add(btn);

                    this.Controls.Add(panel);

                    x = x + 200;
                    if (i != 0 && i % 3 == 0)
                    {
                        x = 10;
                        y = y + 200;
                    }
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
          //  private void Sample_Click(object sender, EventArgs e)//add momo
           // {
            //    Button button = (sender as Button);
             //   MessageBox.Show("Text:" + button.Text, "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
