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
    public partial class Bakery_design : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public Bakery_design()
        {
            InitializeComponent();
        }
        private string GetFoodPrice(string bakeryname, string type)//to get bakery iteam price
        {
            string query2 = "Select top(1) Price from Bakery1 where Bakery_Name='" + bakeryname + "' and type='" + type + "'";
            SqlCommand cmd2 = new SqlCommand(query2, canteen);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            var price = dt2.Rows[0].ItemArray[0].ToString();
            return price;
        }

        //for donuts
        int donuts_chocolate = 0;
        int donuts_strawberry = 0;
        int total_donuts = 0;
        int countCDP = 0;
        int countSDP = 0;
        //
        private void button7_Click(object sender, EventArgs e)//add dounots
        {
            if (donuts_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)donuts_box.SelectedItem == "Chocolate Frosted")
            {
                countCDP++;
                donuts_chocolate++;
                donuts_display.Text = donuts_chocolate.ToString();
            }

            else if ((string)donuts_box.SelectedItem == "Strawberry Frosted")
            {
                countSDP++;
                donuts_chocolate++;
                donuts_display.Text = donuts_chocolate.ToString();
            }
            try
            {
                canteen.Open();


                string donuts_price = GetFoodPrice("Donuts", donuts_box.Text);
                int donuts_price2 = int.Parse(donuts_price);
                string bakery1_donuts = donuts.Text;
                string donuts_Type = donuts_box.Text;
                string donuts_Quantity = donuts_display.Text;
                int donuts_Quantity2 = int.Parse(donuts_Quantity);
                total_donuts = donuts_price2 * donuts_Quantity2;
                if (countCDP == 1 || countSDP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", bakery1_donuts);
                    cmd.Parameters.AddWithValue("@parameter_Type", donuts_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", donuts_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_donuts);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_donuts + "' and Type='" + donuts_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", donuts_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_donuts);
                    cmd.ExecuteNonQuery();
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

        private void donuts_box_SelectedIndexChanged(object sender, EventArgs e)// donuts box
        {

            if ((string)donuts_box.SelectedItem == "Chocolate Frosted")
            {


                donuts_display.Text = donuts_chocolate.ToString();
            }

            else if ((string)donuts_box.SelectedItem == "Strawberry Frosted")
            {


                donuts_display.Text = donuts_strawberry.ToString();
            }
            try
            {
                canteen.Open();


                if (donuts_box.SelectedItem == null)
                {
                    donuts_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Donuts", donuts_box.Text);
                    donuts_price.Text = price;
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

        private void button8_Click(object sender, EventArgs e)//remove donuts
        {
            string donuts_quantity3 = donuts_display.Text;
            int donuts_quantity4 = int.Parse(donuts_quantity3);
            if (donuts_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)donuts_box.SelectedItem == "Chocolate Frosted")
                {

                    donuts_chocolate--;
                    donuts_display.Text = donuts_chocolate.ToString();
                }

                else if ((string)donuts_box.SelectedItem == "Strawberry")
                {

                    donuts_strawberry--;
                    donuts_display.Text = donuts_strawberry.ToString();
                }
            }
            try
            {


                canteen.Open();
                string donuts_price3 = GetFoodPrice("Donuts", donuts_box.Text);
                int donuts_price4 = int.Parse(donuts_price3);


                string bakery1_donuts2 = donuts.Text;
                string donuts_Type2 = donuts_box.Text;
                string donuts_Quantity3 = donuts_display.Text;
                int donuts_Quantity4 = int.Parse(donuts_Quantity3);
                total_donuts = (total_donuts * 1) - donuts_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_donuts2 + "' and Type='" + donuts_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", donuts_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_donuts);
                cmd.ExecuteNonQuery();

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
        //for pies
        int pies_fruit = 0;
        int pies_cream = 0;
        int pies_custard = 0;
        int total_pies = 0;
        int countFP2P = 0;
        int countCP2P = 0;
        int countC2P2P = 0;
        //
        private void button1_Click(object sender, EventArgs e)//add pies
        {
            if(pies_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)pies_box.SelectedItem == "Crust Fruit Pie")
            {
                countFP2P++;
                pies_fruit++;
                pies_display.Text = pies_fruit.ToString();
            }

            else if ((string)pies_box.SelectedItem == "Cream Pie")
            {
                countCP2P++;
                pies_cream++;
                pies_display.Text = pies_cream.ToString();
            }
            else if ((string)pies_box.SelectedItem == "Custard Pie")
            {
                countC2P2P++;
                pies_custard++;
                pies_display.Text = pies_custard.ToString();
            }
            try
            {
                canteen.Open();


                string pies_price = GetFoodPrice("Pies", pies_box.Text);
                int pies_price2 = int.Parse(pies_price);
                string bakery1_pies = pies.Text;
                string pies_Type = pies_box.Text;
                string pies_Quantity = pies_display.Text;
                int pies_Quantity2 = int.Parse(pies_Quantity);
                total_pies = pies_price2 * pies_Quantity2;
                if (countC2P2P == 1 || countCP2P == 1 || countFP2P == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", bakery1_pies);
                    cmd.Parameters.AddWithValue("@parameter_Type", pies_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", pies_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_pies);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_pies + "' and Type='" + pies_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", pies_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_pies);
                    cmd.ExecuteNonQuery();
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

        private void button2_Click(object sender, EventArgs e)//remove pies
        {
            string pies_quantity3 = pies_display.Text;
            int pies_quantity4 = int.Parse(pies_quantity3);
            if (pies_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)pies_box.SelectedItem == "Crust Fruit Pie")
                {

                    pies_fruit--;
                    pies_display.Text = pies_fruit.ToString();
                }

                else if ((string)pies_box.SelectedItem == "Cream Pie ")
                {

                    pies_cream--;
                    pies_display.Text = pies_cream.ToString();
                }
                else if((string)pies_box.SelectedItem == "Cusatrd Pie ")
                {
                    pies_custard--;
                    pies_display.Text = pies_cream.ToString();
                        
                }
            }
            try
            {


                canteen.Open();
                string pies_price3 = GetFoodPrice("Pies", pies_box.Text);
                int pies_price4 = int.Parse(pies_price3);


                string bakery1_pies2 = pies.Text;
                string pies_Type2 = pies_box.Text;
                string pies_Quantity3 = pies_display.Text;
                int pies_Quantity4 = int.Parse(pies_Quantity3);
                total_pies = (total_pies * 1) - pies_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_pies2 + "' and Type='" + pies_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", pies_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_pies);
                cmd.ExecuteNonQuery();

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

        private void pies_box_SelectedIndexChanged(object sender, EventArgs e)//pies box
        {
            if ((string)pies_box.SelectedItem == "Crust Fruit Pie")
            {


                pies_display.Text = pies_fruit.ToString();
            }

            else if ((string)pies_box.SelectedItem == "Cream Pie")
            {


                pies_display.Text = pies_cream.ToString();
            }
            else if ((string)pies_box.SelectedItem == "Custard Pie")
            {


                pies_display.Text = pies_custard.ToString();
            }
            try
            {
                canteen.Open();


                if (pies_box.SelectedItem == null)
                {
                    pies_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Pies", pies_box.Text);
                    pies_price.Text = price;
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
        //for cake
        int cake_forest = 0;
        int cake_valvet = 0;
        int cake_chocolate = 0;
        int total_cake = 0;
        int countFCP = 0;
        int countVC2P = 0;
        int countCC2P = 0;
        //
        private void button3_Click(object sender, EventArgs e)//add cake
        {
            if (cake_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)cake_box.SelectedItem == "Black Forest Cake")
            {
                countFCP++;
               cake_forest++;
                cake_display.Text = cake_forest.ToString();
            }

            else if ((string)cake_box.SelectedItem == "Red Valvet Cake")
            {
                countVC2P++;
                cake_valvet++;
                cake_display.Text = cake_valvet.ToString();
            }
            else if ((string)cake_box.SelectedItem == "Chocolate  Valvet Cake")
            {
                countCC2P++;
                cake_chocolate++;
                cake_display.Text = cake_chocolate.ToString();
            }
            try
            {
                canteen.Open();


                string cake_price = GetFoodPrice("Cake", cake_box.Text);
                int cake_price2 = int.Parse(cake_price);
                string bakery1_cake = cake.Text;
                string cake_Type = cake_box.Text;
                string cake_Quantity = cake_display.Text;
                int cake_Quantity2 = int.Parse(cake_Quantity);
                total_cake = cake_price2 * cake_Quantity2;
                if (countCC2P == 1 || countVC2P == 1 || countFCP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", bakery1_cake);
                    cmd.Parameters.AddWithValue("@parameter_Type", cake_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", cake_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_cake);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_cake + "' and Type='" + cake_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", cake_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_cake);
                    cmd.ExecuteNonQuery();
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

        private void button9_Click(object sender, EventArgs e)//remove cake
        {
            string cake_quantity3 = cake_display.Text;
            int cake_quantity4 = int.Parse(cake_quantity3);
            if (cake_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)cake_box.SelectedItem == "Black Forest Cake")
                {

                    cake_forest--;
                    cake_display.Text = cake_forest.ToString();
                }

                else if ((string)cake_box.SelectedItem == "Red Valvet Cake ")
                {

                    cake_valvet--;
                    cake_display.Text = cake_valvet.ToString();
                }
                else if ((string)cake_box.SelectedItem == "Chocolate Valvet Cake ")
                {
                    cake_chocolate--;
                    cake_display.Text = cake_chocolate.ToString();

                }
            }
            try
            {


                canteen.Open();
                string cake_price3 = GetFoodPrice("Cake", cake_box.Text);
                int cake_price4 = int.Parse(cake_price3);
                string bakery1_cake2 = cake.Text;
                string cake_Type2 = cake_box.Text;
                string cake_Quantity3 = cake_display.Text;
                int cake_Quantity4 = int.Parse(cake_Quantity3);
                total_cake = (total_cake * 1) - cake_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_cake2 + "' and Type='" + cake_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", cake_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_cake);
                cmd.ExecuteNonQuery();

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

        private void cake_box_SelectedIndexChanged(object sender, EventArgs e)//cake box
        {
            if ((string)cake_box.SelectedItem == "Black Forest Cake")
            {


                cake_display.Text = cake_forest.ToString();
            }

            else if ((string)cake_box.SelectedItem == "Red Valvet Cake")
            {


                cake_display.Text = cake_valvet.ToString();
            }
            else if ((string)cake_box.SelectedItem == "Chocolate Valvet Cake")
            {


                cake_display.Text = cake_chocolate.ToString();
            }
            try
            {
                canteen.Open();


                if (cake_box.SelectedItem == null)
                {
                    cake_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Cake", cake_box.Text);
                    cake_price.Text = price;
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
        //for bread
        int bread_baguette = 0;
        int bread_rye = 0;
        int bread_bagels = 0;
        int total_bread = 0;
        int countBB2P = 0;
        int countRB2P = 0;
        int countB2B2P = 0;
        //
        private void button4_Click(object sender, EventArgs e)// add bread
        {
            if (bread_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)bread_box.SelectedItem == "Baguette Bread")
            {
                countBB2P++;
                bread_baguette++;
                bread_display.Text = bread_baguette.ToString();
            }

            else if ((string)bread_box.SelectedItem == "Rye Bread")
            {
                countRB2P++;
                bread_rye++;
                bread_display.Text = bread_rye.ToString();
            }
            else if ((string)bread_box.SelectedItem == "Bagels Bread")
            {
                countB2B2P++;
                bread_bagels++;
                bread_display.Text = bread_bagels.ToString();
            }
            try
            {
                canteen.Open();


                string bread_price = GetFoodPrice("Bread", bread_box.Text);
                int bread_price2 = int.Parse(bread_price);
                string bakery1_bread = bread.Text;
                string bread_Type = bread_box.Text;
                string bread_Quantity = bread_display.Text;
                int bread_Quantity2 = int.Parse(bread_Quantity);
                total_bread = bread_price2 * bread_Quantity2;
                if (countBB2P == 1 || countRB2P == 1 || countB2B2P == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", bakery1_bread);
                    cmd.Parameters.AddWithValue("@parameter_Type", bread_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", bread_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_bread);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_bread + "' and Type='" + bread_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", bread_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_bread);
                    cmd.ExecuteNonQuery();
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

        private void button10_Click(object sender, EventArgs e)//remove bread
        {
            string bread_quantity3 = bread_display.Text;
            int bread_quantity4 = int.Parse(bread_quantity3);
            if (bread_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)bread_box.SelectedItem == "Baguette Bread")
                {

                    bread_baguette--;
                    bread_display.Text = bread_baguette.ToString();
                }

                else if ((string)bread_box.SelectedItem == "Rye Bread ")
                {

                    bread_rye--;
                    bread_display.Text = bread_rye.ToString();
                }
                else if ((string)bread_box.SelectedItem == "Bagels Bread ")
                {
                    bread_bagels--;
                    bread_display.Text = bread_bagels.ToString();

                }
            }
            try
            {


                canteen.Open();
                string bread_price3 = GetFoodPrice("Bread", bread_box.Text);
                int bread_price4 = int.Parse(bread_price3);
                string bakery1_bread2 = bread.Text;
                string bread_Type2 = bread_box.Text;
                string bread_Quantity3 = bread_display.Text;
                int bread_Quantity4 = int.Parse(bread_Quantity3);
                total_bread = (total_bread * 1) - bread_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_bread2 + "' and Type='" + bread_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", bread_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_bread);
                cmd.ExecuteNonQuery();

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

        private void bread_box_SelectedIndexChanged(object sender, EventArgs e)//bread box
        {
            if ((string)bread_box.SelectedItem == "Baguette Bread")
            {


                bread_display.Text = bread_baguette.ToString();
            }

            else if ((string)bread_box.SelectedItem == "Rye Bread")
            {


                bread_display.Text = bread_rye.ToString();
            }
            else if ((string)bread_box.SelectedItem == "Bagels Bread")
            {


                bread_display.Text = bread_bagels.ToString();
            }
            try
            {
                canteen.Open();


                if (bread_box.SelectedItem == null)
                {
                    bread_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Bread", bread_box.Text);
                    bread_price.Text = price;
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
        //for custard
        int custard_egg = 0;
        int custard_baked = 0;
        int total_custard = 0;
        int countEC3P = 0;
        int countBC3P = 0;
        //

        private void button5_Click(object sender, EventArgs e)//add custard
        {
            if (custard_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)custard_box.SelectedItem == "Egg Custard")
            {
                countEC3P++;
                custard_egg++;
                custard_display.Text = custard_egg.ToString();
            }

            else if ((string)custard_box.SelectedItem == "Baked Custard")
            {
                countBC3P++;
                custard_baked++;
                custard_display.Text = custard_baked.ToString();
            }
            
            try
            {
                canteen.Open();


                string custard_price = GetFoodPrice("Custard", custard_box.Text);
                int custard_price2 = int.Parse(custard_price);
                string bakery1_custard = custard.Text;
                string custard_Type = custard_box.Text;
                string custard_Quantity = custard_display.Text;
                int custard_Quantity2 = int.Parse(custard_Quantity);
                total_custard = custard_price2 * custard_Quantity2;
                if ( countEC3P == 1 || countBC3P == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", bakery1_custard);
                    cmd.Parameters.AddWithValue("@parameter_Type", custard_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", custard_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_custard);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_custard + "' and Type='" + custard_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity",custard_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_custard);
                    cmd.ExecuteNonQuery();
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

        private void button6_Click(object sender, EventArgs e)//remove custard
        {
            string custard_quantity3 = custard_display.Text;
            int custard_quantity4 = int.Parse(custard_quantity3);
            if (custard_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)custard_box.SelectedItem == "Egg Custard")
                {

                   custard_egg--;
                    custard_display.Text = custard_egg.ToString();
                }

                else if ((string)custard_box.SelectedItem == "Baked Custard ")
                {

                    custard_baked--;
                    custard_display.Text = custard_baked.ToString();
                }
         
            }
            try
            {


                canteen.Open();
                string custard_price3 = GetFoodPrice("Custard", custard_box.Text);
                int custard_price4 = int.Parse(custard_price3);
                string bakery1_custard2 = custard.Text;
                string custard_Type2 = custard_box.Text;
                string custard_Quantity3 = custard_display.Text;
                int custard_Quantity4 = int.Parse(custard_Quantity3);
                total_custard = (total_custard * 1) - custard_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_custard2 + "' and Type='" + custard_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", custard_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_custard);
                cmd.ExecuteNonQuery();

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

        private void custard_box_SelectedIndexChanged(object sender, EventArgs e)//custard box
        {
            if ((string)custard_box.SelectedItem == "Egg Custard")
            {


                custard_display.Text = custard_egg.ToString();
            }

            else if ((string)custard_box.SelectedItem == "Baked Custard")
            {


                custard_display.Text = custard_baked.ToString();
            }
          
            try
            {
                canteen.Open();


                if (custard_box.SelectedItem == null)
                {
                    custard_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Custard", custard_box.Text);
                    custard_price.Text = price;
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
        //for cookies
        int cookies_chocolate = 0;
        int cookies_peanut = 0;
        int total_cookies = 0;
        int countCC4P = 0;
        int countPC4P = 0;
        //
        private void button11_Click(object sender, EventArgs e)//add cookies
        {
            if (cookies_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)cookies_box.SelectedItem == "Chocolate Chip Cookies")
            {
                countCC4P++;
                cookies_chocolate++;
                cookies_display.Text = cookies_chocolate.ToString();
            }

            else if ((string)cookies_box.SelectedItem == "Peanut Butter Cookies")
            {
                countPC4P++;
                cookies_peanut++;
                cookies_display.Text = cookies_peanut.ToString();
            }

            try
            {
                canteen.Open();


                string cookies_price = GetFoodPrice("Cookies", cookies_box.Text);
                int cookies_price2 = int.Parse(cookies_price);
                string bakery1_cookies = cookies.Text;
                string cookies_Type = cookies_box.Text;
                string cookies_Quantity = cookies_display.Text;
                int cookies_Quantity2 = int.Parse(cookies_Quantity);
                total_cookies = cookies_price2 * cookies_Quantity2;
                if (countPC4P == 1 || countCC4P == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", bakery1_cookies);
                    cmd.Parameters.AddWithValue("@parameter_Type", cookies_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", cookies_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_cookies);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_cookies + "' and Type='" + cookies_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", cookies_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_cookies);
                    cmd.ExecuteNonQuery();
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

        private void button12_Click(object sender, EventArgs e)//remove cookies
        {
            string cookies_quantity3 = cookies_display.Text;
            int cookies_quantity4 = int.Parse(cookies_quantity3);
            if (cookies_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)cookies_box.SelectedItem == "Chocolate Chip Cookies ")
                {

                    cookies_chocolate--;
                    cookies_display.Text = cookies_chocolate.ToString();
                }

                else if ((string)cookies_box.SelectedItem == "Peanut Butter Cookies ")
                {

                    cookies_peanut--;
                    cookies_display.Text = cookies_peanut.ToString();
                }

            }
            try
            {


                canteen.Open();
                string cookies_price3 = GetFoodPrice("Cookies", cookies_box.Text);
                int cookies_price4 = int.Parse(cookies_price3);
                string bakery1_cookies2 = cookies.Text;
                string cookies_Type2 = cookies_box.Text;
                string cookies_Quantity3 = cookies_display.Text;
                int cookies_Quantity4 = int.Parse(cookies_Quantity3);
                total_cookies = (total_cookies * 1) - cookies_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + bakery1_cookies2 + "' and Type='" + cookies_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", cookies_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_cookies);
                cmd.ExecuteNonQuery();

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

        private void cookies_box_SelectedIndexChanged(object sender, EventArgs e)//cookies box
        {
            if ((string)cookies_box.SelectedItem == "Chocolate Chip Cookies")
            {


                cookies_display.Text = cookies_chocolate.ToString();
            }

            else if ((string)cookies_box.SelectedItem == "Peanut Butter Cookies ")
            {


                cookies_display.Text = cookies_peanut.ToString();
            }

            try
            {
                canteen.Open();


                if (cookies_box.SelectedItem == null)
                {
                    cookies_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Cookies", cookies_box.Text);
                    cookies_price.Text = price;
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
