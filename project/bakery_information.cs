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
    }
}
