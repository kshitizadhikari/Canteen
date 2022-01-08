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
    public partial class Drinks_design : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public Drinks_design()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Drinks_design_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private string GetFoodPrice(string drinkname, string type)//to get drink price
        {
            string query2 = "Select top(1) Price from Drink where Drink_Name='" + drinkname + "' and type='" + type + "'";
            SqlCommand cmd2 = new SqlCommand(query2, canteen);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            var price = dt2.Rows[0].ItemArray[0].ToString();
            return price;
        }

        //for coffee
        int coffee_black = 0;
        int coffee_cap = 0;
        int coffee_flat = 0;
        int total_coffee = 0;
        int countBCP = 0;
        int countCCP = 0;
        int countFCP = 0;
        //
        private void button7_Click(object sender, EventArgs e)//add coffee
        {
            if (coffee_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)coffee_box.SelectedItem == "Black Coffee")
            {
                countBCP++;
                coffee_black++;
                coffee_display.Text = coffee_black.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Cappuccino")
            {
                countCCP++;
                coffee_cap++;
                coffee_display.Text = coffee_cap.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Flat White")
            {
                countFCP++;
                coffee_flat++;
                coffee_display.Text = coffee_flat.ToString();
            }
            try
            {
                canteen.Open();


                string coffee_price = GetFoodPrice("Coffee", coffee_box.Text);
                int coffee_price2 = int.Parse(coffee_price);
                string drink1_coffee = coffee.Text;
                string coffee_Type = coffee_box.Text;
                string coffee_Quantity = coffee_display.Text;
                int coffee_Quantity2 = int.Parse(coffee_Quantity);
                total_coffee = coffee_price2 * coffee_Quantity2;
                if (countBCP == 1 || countCCP == 1 || countFCP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", drink1_coffee);
                    cmd.Parameters.AddWithValue("@parameter_Type", coffee_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", coffee_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_coffee);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_coffee + "' and Type='" + coffee_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", coffee_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_coffee);
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

        private void button8_Click(object sender, EventArgs e)//remove coffee
        {
            string coffee_quantity3 = coffee_display.Text;
            int coffee_quantity4 = int.Parse(coffee_quantity3);
            if (coffee_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)coffee_box.SelectedItem == "Black Coffee")
                {

                    coffee_black--;
                    coffee_display.Text = coffee_black.ToString();
                }
                else if ((string)coffee_box.SelectedItem == "Cappuccino")
                {

                    coffee_cap--;
                    coffee_display.Text = coffee_cap.ToString();
                }
                else if ((string)coffee_box.SelectedItem == "Flat White")
                {

                    coffee_flat--;
                    coffee_display.Text = coffee_flat.ToString();
                }
            }
            try
            {


                canteen.Open();
                string coffee_price3 = GetFoodPrice("Coffee", coffee_box.Text);
                int coffee_price4 = int.Parse(coffee_price3);


                string drink1_coffee2 = coffee.Text;
                string coffee_Type2 = coffee_box.Text;
                string coffee_Quantity3 = coffee_display.Text;
                int coffee_Quantity4 = int.Parse(coffee_Quantity3);
                total_coffee = (total_coffee * 1) - coffee_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_coffee2 + "' and Type='" + coffee_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", coffee_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_coffee);
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

        private void coffee_box_SelectedIndexChanged(object sender, EventArgs e)//coffee box
        {
            if ((string)coffee_box.SelectedItem == "Black Coffee")
            {


                coffee_display.Text = coffee_black.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Cappuccino")
            {


                coffee_display.Text = coffee_cap.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Flat White")
            {


                coffee_display.Text = coffee_flat.ToString();
            }
            try
            {
                canteen.Open();


                if (coffee_box.SelectedItem == null)
                {
                    coffee_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Coffee", coffee_box.Text);
                    coffee_price.Text = price;
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
        //for tea
        int tea_black = 0;
        int tea_milk = 0;
        int tea_lemon = 0;
        int tea_green = 0;
        int total_tea = 0;
        int countBTP = 0;
        int countMTP = 0;
        int countLTP = 0;
        int countGTP = 0;
        //
        private void button1_Click(object sender, EventArgs e)//add tea
        {
            if (tea_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)tea_box.SelectedItem == "Black Tea")
            {
                countBTP++;
                tea_black++;
                tea_display.Text = tea_black.ToString();
            }
            else if ((string)tea_box.SelectedItem == "Milk Tea")
            {
                countMTP++;
                tea_milk++;
                tea_display.Text = tea_milk.ToString();
            }
            else if ((string)tea_box.SelectedItem == "Lemon Tea")
            {
                countLTP++;
                tea_lemon++;
                tea_display.Text = tea_lemon.ToString();
            }
            else if ((string)tea_box.SelectedItem == "Green Tea")
            {
                countGTP++;
                tea_green++;
                tea_display.Text = tea_green.ToString();
            }
            try
            {
                canteen.Open();


                string tea_price = GetFoodPrice("Tea", tea_box.Text);
                int tea_price2 = int.Parse(tea_price);
                string drink1_tea = tea.Text;
                string tea_Type = tea_box.Text;
                string tea_Quantity = tea_display.Text;
                int tea_Quantity2 = int.Parse(tea_Quantity);
                total_tea = tea_price2 * tea_Quantity2;
                if (countBTP == 1 || countMTP == 1 || countLTP == 1 || countGTP ==1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", drink1_tea);
                    cmd.Parameters.AddWithValue("@parameter_Type", tea_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", tea_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_tea);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_tea + "' and Type='" + tea_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", tea_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_tea);
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

        private void tea_box_SelectedIndexChanged(object sender, EventArgs e)//tea box
        {
            if ((string)tea_box.SelectedItem == "Black Tea")
            {


                tea_display.Text = tea_black.ToString();
            }
            else if ((string)tea_box.SelectedItem == "Milk Tea")
            {


                tea_display.Text = tea_milk.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Lemon Tea")
            {


                tea_display.Text = tea_lemon.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Green Tea")
            {


                tea_display.Text = tea_green.ToString();
            }
            try
            {
                canteen.Open();


                if (tea_box.SelectedItem == null)
                {
                    tea_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Tea", tea_box.Text);
                    tea_price.Text = price;
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

        private void button5_Click(object sender, EventArgs e)//remove juice
        {
            string juice_quantity3 = juice_display.Text;
            int juice_quantity4 = int.Parse(juice_quantity3);
            if (juice_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)juice_box.SelectedItem == "Mango")
                {

                    juice_mango--;
                    juice_display.Text = juice_mango.ToString();
                }
                else if ((string)soft_box.SelectedItem == "Apple")
                {

                    juice_apple--;
                    juice_display.Text = juice_apple.ToString();
                }
                else if ((string)lassi_box.SelectedItem == "Pineapple")
                {

                    juice_pineapple--;
                    juice_display.Text = juice_pineapple.ToString();
                }
            }
            try
            {


                canteen.Open();
                string juice_price3 = GetFoodPrice("Juice", juice_box.Text);
                int juice_price4 = int.Parse(juice_price3);


                string drink1_juice2 = juice.Text;
                string juice_Type2 = juice_box.Text;
                string juice_Quantity3 = juice_display.Text;
                int juice_Quantity4 = int.Parse(juice_Quantity3);
                total_juice = (total_juice * 1) - juice_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_juice2 + "' and Type='" + juice_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", juice_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_juice);
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

        private void button2_Click(object sender, EventArgs e)//remove tea
        {

            string tea_quantity3 = tea_display.Text;
            int tea_quantity4 = int.Parse(tea_quantity3);
            if (tea_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)tea_box.SelectedItem == "Black Tea")
                {

                    tea_black--;
                    tea_display.Text = tea_black.ToString();
                }
                else if ((string)tea_box.SelectedItem == "Milk Tea")
                {

                   tea_milk--;
                    tea_display.Text = tea_milk.ToString();
                }
                else if ((string)coffee_box.SelectedItem == "Lemon Tea")
                {

                    tea_lemon--;
                    tea_display.Text = tea_lemon.ToString();
                }
                else if ((string)coffee_box.SelectedItem == "Green Tea")
                {

                    tea_green--;
                    tea_display.Text = tea_green.ToString();
                }

            }
            try
            {


                canteen.Open();
                string tea_price3 = GetFoodPrice("Tea", tea_box.Text);
                int tea_price4 = int.Parse(tea_price3);


                string drink1_tea2 = tea.Text;
                string tea_Type2 = tea_box.Text;
                string tea_Quantity3 = tea_display.Text;
                int tea_Quantity4 = int.Parse(tea_Quantity3);
                total_tea = (total_tea * 1) - tea_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_tea2 + "' and Type='" + tea_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", tea_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_tea);
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
        //for soft drink
        int soft_coke = 0;
        int soft_fanta = 0;
        int soft_sprite = 0;
        int total_soft = 0;
        int countCSP = 0;
        int countFSP = 0;
        int countSSP = 0;
        //
        private void button9_Click(object sender, EventArgs e)//add soft drink
        {
            if (soft_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)soft_box.SelectedItem == "Coke")
            {
                countCSP++;
                soft_coke++;
                soft_display.Text = soft_coke.ToString();
            }
            else if ((string)soft_box.SelectedItem == "Fanta")
            {
                countFSP++;
                soft_fanta++;
                soft_display.Text = soft_fanta.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Sprite")
            {
                countSSP++;
                soft_sprite++;
                soft_display.Text = soft_sprite.ToString();
            }
            try
            {
                canteen.Open();


                string soft_price = GetFoodPrice("Soft Drink", soft_box.Text);
                int soft_price2 = int.Parse(soft_price);
                string drink1_soft = soft.Text;
                string soft_Type = soft_box.Text;
                string soft_Quantity = soft_display.Text;
                int soft_Quantity2 = int.Parse(soft_Quantity);
                total_soft = soft_price2 * soft_Quantity2;
                if (countFSP == 1 || countCSP == 1 || countSSP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", drink1_soft);
                    cmd.Parameters.AddWithValue("@parameter_Type", soft_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", soft_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_soft);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_soft + "' and Type='" + soft_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", soft_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_soft);
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

        private void button3_Click(object sender, EventArgs e)// remove soft drink
        {
            string soft_quantity3 = soft_display.Text;
            int soft_quantity4 = int.Parse(soft_quantity3);
            if (soft_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)soft_box.SelectedItem == "Coke")
                {

                    soft_coke--;
                    soft_display.Text = soft_coke.ToString();
                }
                else if ((string)soft_box.SelectedItem == "Fanta")
                {

                    soft_fanta--;
                    soft_display.Text = soft_fanta.ToString();
                }
                else if ((string)coffee_box.SelectedItem == "Sprite")
                {

                    soft_sprite--;
                    soft_display.Text = soft_sprite.ToString();
                }
            }
            try
            {


                canteen.Open();
                string soft_price3 = GetFoodPrice("Soft Drink", soft_box.Text);
                int soft_price4 = int.Parse(soft_price3);


                string drink1_soft2 = soft.Text;
                string soft_Type2 = soft_box.Text;
                string soft_Quantity3 = soft_display.Text;
                int soft_Quantity4 = int.Parse(soft_Quantity3);
                total_soft = (total_soft * 1) - soft_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_soft2 + "' and Type='" + soft_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", soft_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_soft);
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

        private void soft_box_SelectedIndexChanged(object sender, EventArgs e)//soft box
        {
            if ((string)soft_box.SelectedItem == "Coke")
            {


                soft_display.Text = soft_coke.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Fanta")
            {


                soft_display.Text = soft_fanta.ToString();
            }
            else if ((string)coffee_box.SelectedItem == "Sprite")
            {


                soft_display.Text = soft_sprite.ToString();
            }
            try
            {
                canteen.Open();


                if (soft_box.SelectedItem == null)
                {
                    soft_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Soft Drink", soft_box.Text);
                    soft_price.Text = price;
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
        //for lassi
        int lassi_mango = 0;
        int lassi_strawberry = 0;
        int lassi_pineapple = 0;
        int total_lassi = 0;
        int countMLP = 0;
        int countSLP = 0;
        int countPLP = 0;
        //
        private void button10_Click(object sender, EventArgs e)//Add lassi
        {
            if (lassi_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)lassi_box.SelectedItem == "Mango")
            {
                countMLP++;
                lassi_mango++;
                lassi_display.Text = lassi_mango.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Strawberry")
            {
                countSLP++;
                lassi_strawberry++;
                lassi_display.Text = lassi_strawberry.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Pineapple")
            {
                countPLP++;
                lassi_pineapple++;
                lassi_display.Text = lassi_pineapple.ToString();
            }
            try
            {
                canteen.Open();


                string lassi_price = GetFoodPrice("Lassi", lassi_box.Text);
                int lassi_price2 = int.Parse(lassi_price);
                string drink1_lassi = lassi.Text;
                string lassi_Type = lassi_box.Text;
                string lassi_Quantity = lassi_display.Text;
                int lassi_Quantity2 = int.Parse(lassi_Quantity);
                total_lassi = lassi_price2 * lassi_Quantity2;
                if (countMLP == 1 || countSLP == 1 || countPLP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", drink1_lassi);
                    cmd.Parameters.AddWithValue("@parameter_Type", lassi_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", lassi_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_lassi);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_lassi + "' and Type='" + lassi_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", lassi_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_lassi);
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

        private void button4_Click(object sender, EventArgs e)//remove lassi
        {
            string lassi_quantity3 = lassi_display.Text;
            int lassi_quantity4 = int.Parse(lassi_quantity3);
            if (lassi_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)lassi_box.SelectedItem == "Mango")
                {

                    lassi_mango--;
                    lassi_display.Text = lassi_mango.ToString();
                }
                else if ((string)soft_box.SelectedItem == "Strawberry")
                {

                    lassi_strawberry--;
                    lassi_display.Text = lassi_strawberry.ToString();
                }
                else if ((string)lassi_box.SelectedItem == "Pineapple")
                {

                    lassi_pineapple--;
                    lassi_display.Text = lassi_pineapple.ToString();
                }
            }
            try
            {


                canteen.Open();
                string lassi_price3 = GetFoodPrice("Lassi", lassi_box.Text);
                int lassi_price4 = int.Parse(lassi_price3);


                string drink1_lassi2 = lassi.Text;
                string lassi_Type2 = lassi_box.Text;
                string lassi_Quantity3 = lassi_display.Text;
                int lassi_Quantity4 = int.Parse(lassi_Quantity3);
                total_lassi = (total_lassi * 1) - lassi_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_lassi2 + "' and Type='" + lassi_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", lassi_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_lassi);
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

        private void lassi_box_SelectedIndexChanged(object sender, EventArgs e)//lassi box
        {

            if ((string)lassi_box.SelectedItem == "Mango")
            {


                lassi_display.Text = lassi_mango.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Strawberry")
            {


                lassi_display.Text = lassi_strawberry.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Pineapple")
            {


                lassi_display.Text = lassi_pineapple.ToString();
            }
            try
            {
                canteen.Open();


                if (lassi_box.SelectedItem == null)
                {
                    lassi_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Lassi", lassi_box.Text);
                    lassi_price.Text = price;
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
        //for juice
        int juice_mango = 0;
        int juice_apple = 0;
        int juice_pineapple = 0;
        int total_juice = 0;
        int countMJP = 0;
        int countAJP = 0;
        int countPJP = 0;
        //
        private void button11_Click(object sender, EventArgs e)//add juice
        {
            if (juice_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)juice_box.SelectedItem == "Mango")
            {
                countMJP++;
                juice_mango++;
                juice_display.Text = juice_mango.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Apple")
            {
                countAJP++;
                juice_apple++;
                juice_display.Text = juice_apple.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Pineapple")
            {
                countPJP++;
                juice_pineapple++;
                juice_display.Text = juice_pineapple.ToString();
            }
            try
            {
                canteen.Open();


                string juice_price = GetFoodPrice("Juice", juice_box.Text);
                int juice_price2 = int.Parse(juice_price);
                string drink1_juice = juice.Text;
                string juice_Type = juice_box.Text;
                string juice_Quantity = juice_display.Text;
                int juice_Quantity2 = int.Parse(juice_Quantity);
                total_juice = juice_price2 * juice_Quantity2;
                if (countMJP == 1 || countPJP == 1 || countAJP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", drink1_juice);
                    cmd.Parameters.AddWithValue("@parameter_Type", juice_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", juice_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_juice);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_juice + "' and Type='" + juice_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", juice_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_juice);
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

        private void juice_box_SelectedIndexChanged(object sender, EventArgs e)//juice box
        {

            if ((string)juice_box.SelectedItem == "Mango")
            {


                juice_display.Text = juice_mango.ToString();
            }
            else if ((string)juice_box.SelectedItem == "Apple")
            {


                juice_display.Text = juice_apple.ToString();
            }
            else if ((string)lassi_box.SelectedItem == "Pineapple")
            {


                juice_display.Text = juice_pineapple.ToString();
            }
            try
            {
                canteen.Open();


                if (juice_box.SelectedItem == null)
                {
                    juice_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Juice", juice_box.Text);
                    juice_price.Text = price;
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
        //for milkshake
        int milkshake_vanilla = 0;
        int milkshake_chocolate = 0;
       
        int total_milkshake = 0;
        int countVMP = 0;
        int countCMP = 0;
     
        //
        private void button12_Click(object sender, EventArgs e)//add milkshake
        {
            if (milkshake_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)milkshake_box.SelectedItem == "Vanilla")
            {
                countVMP++;
                milkshake_vanilla++;
                milkshake_display.Text = milkshake_vanilla.ToString();
            }
            else if ((string)milkshake_box.SelectedItem == "Chocolate")
            {
                countCMP++;
                milkshake_chocolate++;
                milkshake_display.Text = milkshake_chocolate.ToString();
            }
            
            try
            {
                canteen.Open();


                string milkshake_price = GetFoodPrice("Milkshake", milkshake_box.Text);
                int milkshake_price2 = int.Parse(milkshake_price);
                string drink1_milkshake = milkshake.Text;
                string milkshake_Type = milkshake_box.Text;
                string milkshake_Quantity = milkshake_display.Text;
                int milkshake_Quantity2 = int.Parse(milkshake_Quantity);
                total_milkshake = milkshake_price2 * milkshake_Quantity2;
                if (countVMP == 1 || countCMP == 1 )
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", drink1_milkshake);
                    cmd.Parameters.AddWithValue("@parameter_Type", milkshake_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", milkshake_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_milkshake);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_milkshake + "' and Type='" + milkshake_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", milkshake_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_milkshake);
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

        private void button6_Click(object sender, EventArgs e)//remove milkshake
        {
            string milkshake_quantity3 = milkshake_display.Text;
            int milkshake_quantity4 = int.Parse(milkshake_quantity3);
            if (milkshake_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)milkshake_box.SelectedItem == "Vanilla")
                {

                    milkshake_vanilla--;
                    milkshake_display.Text = milkshake_vanilla.ToString();
                }
                else if ((string)milkshake_box.SelectedItem == "Chocoloate")
                {

                    milkshake_chocolate--;
                    milkshake_display.Text = milkshake_chocolate.ToString();
                }
               
            }
            try
            {


                canteen.Open();
                string milkshake_price3 = GetFoodPrice("Milkshake", milkshake_box.Text);
                int milkshake_price4 = int.Parse(milkshake_price3);


                string drink1_milkshake2 = milkshake.Text;
                string milkshake_Type2 = milkshake_box.Text;
                string milkshake_Quantity3 = milkshake_display.Text;
                int milkshake_Quantity4 = int.Parse(milkshake_Quantity3);
                total_milkshake = (total_milkshake * 1) - milkshake_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + drink1_milkshake2 + "' and Type='" + milkshake_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", milkshake_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_milkshake);
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

        private void milkshake_box_SelectedIndexChanged(object sender, EventArgs e)//milkshake box
        {
            if ((string)milkshake_box.SelectedItem == "Vanilla")
            {


                milkshake_display.Text = milkshake_vanilla.ToString();
            }
            else if ((string)milkshake_box.SelectedItem == "Chocolate")
            {


                milkshake_display.Text = milkshake_chocolate.ToString();
            }
           
            try
            {
                canteen.Open();


                if (milkshake_box.SelectedItem == null)
                {
                    milkshake_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Milkshake", milkshake_box.Text);
                    milkshake_price.Text = price;
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
