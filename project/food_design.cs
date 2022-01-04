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

    public partial class food_design : UserControl
    {
        SqlConnection canteen = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=canteen_management;Integrated Security=True");
        public food_design()
        {

            InitializeComponent();
        }



        //for momo
        int momo_veg = 0;
        int momo_buff = 0;
        int momo_chicken = 0;
        int total_momo = 0;
        int countVP = 0;
        int countBP = 0;
        int countCP = 0;
        //



        private void momoadd_Click(object sender, EventArgs e)//add momo
        {


            if (momo_box1.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)momo_box1.SelectedItem == "Veg")
            {
                countVP++;
                momo_veg++;
                momo_display.Text = momo_veg.ToString();
            }
            else if ((string)momo_box1.SelectedItem == "Buff")
            {
                countBP++;
                momo_buff++;
                momo_display.Text = momo_buff.ToString();
            }
            else if ((string)momo_box1.SelectedItem == "Chicken")
            {
                countCP++;
                momo_chicken++;
                momo_display.Text = momo_chicken.ToString();
            }
            try
            {
                canteen.Open();


                string momo_price = GetFoodPrice("Momo", momo_box1.Text);
                int momo_price2 = int.Parse(momo_price);
                string food1_momo = momo.Text;
                string momo_Type = momo_box1.Text;
                string momo_Quantity = momo_display.Text;
                int momo_Quantity2 = int.Parse(momo_Quantity);
                total_momo = momo_price2 * momo_Quantity2;
                if (countVP == 1 || countCP == 1 || countBP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_momo);
                    cmd.Parameters.AddWithValue("@parameter_Type", momo_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", momo_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_momo);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_momo + "' and Type='" + momo_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", momo_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_momo);
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
        

        private string GetFoodPrice(string foodname, string type)//to get food price
        {
            string query2 = "Select top(1) Price from food where Food_Name='" + foodname + "' and type='" + type + "'";
            SqlCommand cmd2 = new SqlCommand(query2, canteen);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            var price = dt2.Rows[0].ItemArray[0].ToString();
            return price;
        }

        private void UpdateFoodPrice(string foodname, string type)
        {
            canteen.Open();
            string query = "Update food_order set Quantity=@parameter_Quantity where food='" + foodname + "' and Type='" + type + "'";
            SqlCommand cmd = new SqlCommand(query, canteen);
            cmd.Parameters.AddWithValue("@parameter_Quantity", momo_display.Text);
            cmd.Parameters.AddWithValue("@parameter_food", foodname);
            cmd.Parameters.AddWithValue("@parameter_Type", type);
            cmd.ExecuteNonQuery();
            canteen.Close();
        }

        private void momoremove_Click(object sender, EventArgs e)//remove momo
        {
            string momo_quantity3 = momo_display.Text;
            int momo_quantity4 = int.Parse(momo_quantity3);
            if (momo_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)momo_box1.SelectedItem == "Veg")
                {

                    momo_veg--;
                    momo_display.Text = momo_veg.ToString();
                }
                else if ((string)momo_box1.SelectedItem == "Buff")
                {

                    momo_buff--;
                    momo_display.Text = momo_buff.ToString();
                }
                else if ((string)momo_box1.SelectedItem == "Chicken")
                {

                    momo_chicken--;
                    momo_display.Text = momo_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string momo_price3 = GetFoodPrice("Momo", momo_box1.Text);
                int momo_price4 = int.Parse(momo_price3);


                string food1_momo2 = momo.Text;
                string momo_Type2 = momo_box1.Text;
                string momo_Quantity3 = momo_display.Text;
                int momo_Quantity4 = int.Parse(momo_Quantity3);
                total_momo = (total_momo * 1) - momo_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_momo2 + "' and Type='" + momo_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", momo_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_momo);
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


       
        //for chowmein
        int chowmein_veg = 0;
        int chowmein_buff = 0;
        int chowmein_chicken = 0;
        int total_chowmein = 0;
        int countVCP = 0;
        int countBCP = 0;
        int countCCP = 0;
        //
        private void button3_Click(object sender, EventArgs e)//chowmein add
        {
            if (chowmein_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)chowmein_box.SelectedItem == "Veg")
            {
                countVCP++;
                chowmein_veg++;
                chowmein_display.Text = chowmein_veg.ToString();
            }
            else if ((string)chowmein_box.SelectedItem == "Buff")
            {
                countBCP++;
                chowmein_buff++;
                chowmein_display.Text = chowmein_buff.ToString();
            }
            else if ((string)chowmein_box.SelectedItem == "Chicken")
            {
                countCCP++;
                chowmein_chicken++;
                chowmein_display.Text = chowmein_chicken.ToString();
            }
            try
            {
                canteen.Open();


                string chowmein_price = GetFoodPrice("Chowmein", chowmein_box.Text);
                int chowmein_price2 = int.Parse(chowmein_price);
                string food1_chowmein = chowmein.Text;
                string chowmein_Type = chowmein_box.Text;
                string chowmein_Quantity = chowmein_display.Text;
                int chowmein_Quantity2 = int.Parse(chowmein_Quantity);
                total_chowmein = chowmein_price2 * chowmein_Quantity2;
                if (countVCP == 1 || countCCP == 1 || countBCP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_chowmein);
                    cmd.Parameters.AddWithValue("@parameter_Type", chowmein_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", chowmein_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_chowmein);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_chowmein + "' and Type='" + chowmein_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", chowmein_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_chowmein);
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

        private void chowmein_box_SelectedIndexChanged(object sender, EventArgs e)//chowmein box
        {
            if ((string)chowmein_box.SelectedItem == "Veg")
            {


                chowmein_display.Text = chowmein_veg.ToString();
            }
            else if ((string)chowmein_box.SelectedItem == "Buff")
            {


                chowmein_display.Text = chowmein_buff.ToString();
            }
            else if ((string)chowmein_box.SelectedItem == "Chicken")
            {


                chowmein_display.Text = chowmein_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (chowmein_box.SelectedItem == null)
                {
                    chowmein_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Chowmein", chowmein_box.Text);
                    chowmein_price.Text = price;
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

        private void momo_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)//remove chowmein
        {
            string chowmein_quantity3 = chowmein_display.Text;
            int chowmein_quantity4 = int.Parse(chowmein_quantity3);
            if (chowmein_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)chowmein_box.SelectedItem == "Veg")
                {

                    chowmein_veg--;
                    chowmein_display.Text = chowmein_veg.ToString();
                }
                else if ((string)chowmein_box.SelectedItem == "Buff")
                {

                    chowmein_buff--;
                    chowmein_display.Text = chowmein_buff.ToString();
                }
                else if ((string)chowmein_box.SelectedItem == "Chicken")
                {

                    chowmein_chicken--;
                    chowmein_display.Text = chowmein_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string chowmein_price3 = GetFoodPrice("Chowmein", chowmein_box.Text);
                int chowmein_price4 = int.Parse(chowmein_price3);


                string food1_chowmein2 = chowmein.Text;
                string chowmein_Type2 = chowmein_box.Text;
                string chowmein_Quantity3 = chowmein_display.Text;
                int chowmein_Quantity4 = int.Parse(chowmein_Quantity3);
                total_chowmein = (total_chowmein * 1) - chowmein_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_chowmein2 + "' and Type='" + chowmein_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", chowmein_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_chowmein);
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
        //for burger
        int burger_veg = 0;
        int burger_chicken = 0;
        int total_burger = 0;
        int countVBP = 0;
        int countCBP = 0;

        //
        private void button11_Click(object sender, EventArgs e)//burger add
        {
            if (burger_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)burger_box.SelectedItem == "Veg")
            {
                countVBP++;
                burger_veg++;
                burger_display.Text = burger_veg.ToString();
            }

            else if ((string)burger_box.SelectedItem == "Chicken")
            {
                countCBP++;
                burger_chicken++;
                burger_display.Text = burger_chicken.ToString();
            }
            try
            {
                canteen.Open();


                string burger_price = GetFoodPrice("Burger", burger_box.Text);
                int burger_price2 = int.Parse(burger_price);
                string food1_burger = burger.Text;
                string burger_Type = burger_box.Text;
                string burger_Quantity = burger_display.Text;
                int burger_Quantity2 = int.Parse(burger_Quantity);
                total_burger = burger_price2 * burger_Quantity2;
                if (countVBP == 1 || countCBP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_burger);
                    cmd.Parameters.AddWithValue("@parameter_Type", burger_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", burger_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_burger);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_burger + "' and Type='" + burger_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", burger_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_burger);
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

        private void burger_box_SelectedIndexChanged(object sender, EventArgs e)//burger box
        {
            if ((string)burger_box.SelectedItem == "Veg")
            {


                burger_display.Text = burger_veg.ToString();
            }

            else if ((string)burger_box.SelectedItem == "Chicken")
            {


                burger_display.Text = burger_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (burger_box.SelectedItem == null)
                {
                    burger_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Burger", burger_box.Text);
                    burger_price.Text = price;
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

        private void button12_Click(object sender, EventArgs e)//remove burger
        {
            string burger_quantity3 = burger_display.Text;
            int burger_quantity4 = int.Parse(burger_quantity3);
            if (burger_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)burger_box.SelectedItem == "Veg")
                {

                    burger_veg--;
                    burger_display.Text = burger_veg.ToString();
                }

                else if ((string)burger_box.SelectedItem == "Chicken")
                {

                    burger_chicken--;
                    burger_display.Text = burger_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string burger_price3 = GetFoodPrice("Burger", burger_box.Text);
                int burger_price4 = int.Parse(burger_price3);


                string food1_burger2 = burger.Text;
                string burger_Type2 = burger_box.Text;
                string burger_Quantity3 = burger_display.Text;
                int burger_Quantity4 = int.Parse(burger_Quantity3);
                total_burger = (total_burger * 1) - burger_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_burger2 + "' and Type='" + burger_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", burger_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_burger);
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
        //for sandwich
        int sandwich_veg = 0;
        int sandwich_chicken = 0;
        int total_sandwich = 0;
        int countVSP = 0;
        int countCSP = 0;

        //
        private void button4_Click(object sender, EventArgs e)//add sandwich
        {
            if (sandwich_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)sandwich_box.SelectedItem == "Veg")
            {
                countVSP++;
                sandwich_veg++;
                sandwich_display.Text = sandwich_veg.ToString();
            }

            else if ((string)sandwich_box.SelectedItem == "Chicken")
            {
                countCSP++;
                sandwich_chicken++;
                sandwich_display.Text = sandwich_chicken.ToString();
            }
            try
            {
                canteen.Open();


                string sandwich_price = GetFoodPrice("Sandwich", sandwich_box.Text);
                int sandwich_price2 = int.Parse(sandwich_price);
                string food1_sandwich = sandwich.Text;
                string sandwich_Type = sandwich_box.Text;
                string sandwich_Quantity = sandwich_display.Text;
                int sandwich_Quantity2 = int.Parse(sandwich_Quantity);
                total_sandwich = sandwich_price2 * sandwich_Quantity2;
                if (countVSP == 1 || countCSP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_sandwich);
                    cmd.Parameters.AddWithValue("@parameter_Type", sandwich_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", sandwich_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_sandwich);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_sandwich + "' and Type='" + sandwich_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", sandwich_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_sandwich);
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

        private void button5_Click(object sender, EventArgs e)//remove sandwich
        {
            string sandwich_quantity3 = sandwich_display.Text;
            int sandwich_quantity4 = int.Parse(sandwich_quantity3);
            if (sandwich_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)sandwich_box.SelectedItem == "Veg")
                {

                    sandwich_veg--;
                    sandwich_display.Text = sandwich_veg.ToString();
                }

                else if ((string)sandwich_box.SelectedItem == "Chicken")
                {

                    sandwich_chicken--;
                    sandwich_display.Text = sandwich_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string sandwich_price3 = GetFoodPrice("Sandwich", sandwich_box.Text);
                int sandwich_price4 = int.Parse(sandwich_price3);


                string food1_sandwich2 = sandwich.Text;
                string sandwich_Type2 = sandwich_box.Text;
                string sandwich_Quantity3 = sandwich_display.Text;
                int sandwich_Quantity4 = int.Parse(sandwich_Quantity3);
                total_sandwich = (total_sandwich * 1) - sandwich_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_sandwich2 + "' and Type='" + sandwich_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", sandwich_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_sandwich);
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

        private void sandwich_box_SelectedIndexChanged(object sender, EventArgs e)//sandwich box
        {
            if ((string)sandwich_box.SelectedItem == "Veg")
            {


                sandwich_display.Text = sandwich_veg.ToString();
            }

            else if ((string)sandwich_box.SelectedItem == "Chicken")
            {


                sandwich_display.Text = sandwich_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (sandwich_box.SelectedItem == null)
                {
                    sandwich_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Sandwich", burger_box.Text);
                    sandwich_price.Text = price;
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
        //for pizza
        int pizza_veg = 0;
        int pizza_pep = 0;
        int pizza_chicken = 0;
        int total_pizza = 0;
        int countVPP = 0;
        int countPPP = 0;
        int countCPP = 0;
        //
        private void button6_Click(object sender, EventArgs e)//add pizza
        {

            if (pizza_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)pizza_box.SelectedItem == "Veg")
            {
                countVPP++;
                pizza_veg++;
                pizza_display.Text = pizza_veg.ToString();
            }

            else if ((string)pizza_box.SelectedItem == "Chicken")
            {
                countCPP++;
                pizza_chicken++;
                pizza_display.Text = pizza_chicken.ToString();
            }
            else if ((string)pizza_box.SelectedItem == "Pepperoni")
            {
                countPPP++;
                pizza_pep++;
                pizza_display.Text = pizza_pep.ToString();
            }
            try
            {
                canteen.Open();


                string pizza_price = GetFoodPrice("Pizza", pizza_box.Text);
                int pizza_price2 = int.Parse(pizza_price);
                string food1_pizza = pizza.Text;
                string pizza_Type = pizza_box.Text;
                string pizza_Quantity = pizza_display.Text;
                int pizza_Quantity2 = int.Parse(pizza_Quantity);
                total_pizza = pizza_price2 * pizza_Quantity2;
                if (countVPP == 1 || countCPP == 1 || countPPP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_pizza);
                    cmd.Parameters.AddWithValue("@parameter_Type", pizza_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", pizza_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_pizza);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_pizza + "' and Type='" + pizza_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", pizza_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_pizza);
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

        private void button7_Click(object sender, EventArgs e)//remove pizza
        {
            string pizza_quantity3 = pizza_display.Text;
            int pizza_quantity4 = int.Parse(pizza_quantity3);
            if (pizza_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)pizza_box.SelectedItem == "Veg")
                {

                    pizza_veg--;
                    pizza_display.Text = pizza_veg.ToString();
                }
                else if ((string)pizza_box.SelectedItem == "Pepperoni")
                {

                    pizza_pep--;
                    pizza_display.Text = pizza_pep.ToString();
                }
                else if ((string)pizza_box.SelectedItem == "Chicken")
                {

                    pizza_chicken--;
                    pizza_display.Text = pizza_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string pizza_price3 = GetFoodPrice("Pizza", pizza_box.Text);
                int pizza_price4 = int.Parse(pizza_price3);


                string food1_pizza2 = pizza.Text;
                string pizza_Type2 = pizza_box.Text;
                string pizza_Quantity3 = pizza_display.Text;
                int pizza_Quantity4 = int.Parse(pizza_Quantity3);
                total_pizza = (total_pizza * 1) - pizza_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_pizza2 + "' and Type='" + pizza_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", pizza_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_pizza);
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

        private void pizza_box_SelectedIndexChanged(object sender, EventArgs e)//pizza box
        {
            if ((string)pizza_box.SelectedItem == "Veg")
            {


                pizza_display.Text = pizza_veg.ToString();
            }
            else if ((string)pizza_box.SelectedItem == "Pepperoni")
            {


                pizza_display.Text = pizza_pep.ToString();
            }
            else if ((string)pizza_box.SelectedItem == "Chicken")
            {


                pizza_display.Text = pizza_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (pizza_box.SelectedItem == null)
                {
                    pizza_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Pizza", pizza_box.Text);
                    pizza_price.Text = price;
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
        //for sandwich
        int sizzler_veg = 0;
        int sizzler_chicken = 0;
        int total_sizzler = 0;
        int countVS2P = 0;
        int countCS2P = 0;

        //
        private void button8_Click(object sender, EventArgs e)//add sizzler
        {
            if (sizzler_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)sizzler_box.SelectedItem == "Veg")
            {
                countVS2P++;
                sizzler_veg++;
                sizzler_display.Text = sizzler_veg.ToString();
            }

            else if ((string)sizzler_box.SelectedItem == "Chicken")
            {
                countCS2P++;
                sizzler_chicken++;
                sizzler_display.Text = sizzler_chicken.ToString();
            }
            try
            {
                canteen.Open();


                string sizzler_price = GetFoodPrice("Sizzler", sizzler_box.Text);
                int sizzler_price2 = int.Parse(sizzler_price);
                string food1_sizzler = sizzler.Text;
                string sizzler_Type = sizzler_box.Text;
                string sizzler_Quantity = sizzler_display.Text;
                int sizzler_Quantity2 = int.Parse(sizzler_Quantity);
                total_sizzler = sizzler_price2 * sizzler_Quantity2;
                if (countVS2P == 1 || countCS2P == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_sizzler);
                    cmd.Parameters.AddWithValue("@parameter_Type", sizzler_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", sizzler_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_sizzler);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_sizzler + "' and Type='" + sizzler_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", sizzler_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_sizzler);
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

        private void sizzler_box_SelectedIndexChanged(object sender, EventArgs e)//sizzler box
        {
            if ((string)sizzler_box.SelectedItem == "Veg")
            {


                sizzler_display.Text = sizzler_veg.ToString();
            }

            else if ((string)sizzler_box.SelectedItem == "Chicken")
            {


                sizzler_display.Text = sizzler_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (sizzler_box.SelectedItem == null)
                {
                    sizzler_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Sizzler", sizzler_box.Text);
                    sizzler_price.Text = price;
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

        private void button9_Click(object sender, EventArgs e)//remove sizzler
        {
            string sizzler_quantity3 = sizzler_display.Text;
            int sizzler_quantity4 = int.Parse(sizzler_quantity3);
            if (sizzler_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)sizzler_box.SelectedItem == "Veg")
                {

                    sizzler_veg--;
                    sizzler_display.Text = sizzler_veg.ToString();
                }

                else if ((string)sizzler_box.SelectedItem == "Chicken")
                {

                    sizzler_chicken--;
                    sizzler_display.Text = sizzler_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string sizzler_price3 = GetFoodPrice("Sizzler", sizzler_box.Text);
                int sizzler_price4 = int.Parse(sizzler_price3);


                string food1_sizzler2 = sizzler.Text;
                string sizzler_Type2 = sizzler_box.Text;
                string sizzler_Quantity3 = sizzler_display.Text;
                int sizzler_Quantity4 = int.Parse(sizzler_Quantity3);
                total_sizzler = (total_sizzler * 1) - sizzler_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_sizzler2 + "' and Type='" + sizzler_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", sizzler_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_sizzler);
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
        //for katti roll
        int katti_veg = 0;
        int katti_egg = 0;
        int katti_chicken = 0;
        int total_katti = 0;
        int countVKP = 0;
        int countEKP = 0;
        int countCKP = 0;
        //
        private void button14_Click(object sender, EventArgs e)//add katti roll
        {
            if (katti_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)katti_box.SelectedItem == "Veg")
            {
                countVKP++;
                katti_veg++;
                katti_display.Text = katti_veg.ToString();
            }

            else if ((string)katti_box.SelectedItem == "Chicken")
            {
                countCKP++;
                katti_chicken++;
                katti_display.Text = katti_chicken.ToString();
            }
            else if ((string)katti_box.SelectedItem == "Egg")
            {
                countEKP++;
                katti_egg++;
                katti_display.Text = katti_egg.ToString();
            }
            try
            {
                canteen.Open();


                string katti_price = GetFoodPrice("Kattiroll", katti_box.Text);
                int katti_price2 = int.Parse(katti_price);
                string food1_katti = katti.Text;
                string katti_Type = katti_box.Text;
                string katti_Quantity = katti_display.Text;
                int katti_Quantity2 = int.Parse(katti_Quantity);
                total_katti = katti_price2 * katti_Quantity2;
                if (countEKP == 1 || countCKP == 1 || countVKP == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_katti);
                    cmd.Parameters.AddWithValue("@parameter_Type", katti_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", katti_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_katti);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_katti + "' and Type='" + katti_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", katti_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_katti);
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

        private void katti_box_SelectedIndexChanged(object sender, EventArgs e)//katti roll box
        {
            if ((string)katti_box.SelectedItem == "Veg")
            {


                katti_display.Text = katti_veg.ToString();
            }
            else if ((string)katti_box.SelectedItem == "Egg")
            {


                katti_display.Text = katti_egg.ToString();
            }
            else if ((string)katti_box.SelectedItem == "Chicken")
            {


                katti_display.Text = katti_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (katti_box.SelectedItem == null)
                {
                    katti_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Kattiroll", katti_box.Text);
                    katti_price.Text = price;
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

        private void button13_Click(object sender, EventArgs e)//remove katti roll
        {
            string katti_quantity3 = katti_display.Text;
            int katti_quantity4 = int.Parse(katti_quantity3);
            if (katti_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)katti_box.SelectedItem == "Veg")
                {

                    katti_veg--;
                    katti_display.Text = katti_veg.ToString();
                }
                else if ((string)katti_box.SelectedItem == "Egg")
                {

                    katti_egg--;
                    katti_display.Text = katti_egg.ToString();
                }
                else if ((string)katti_box.SelectedItem == "Chicken")
                {

                    katti_chicken--;
                    katti_display.Text = katti_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string katti_price3 = GetFoodPrice("Kattiroll", katti_box.Text);
                int katti_price4 = int.Parse(katti_price3);


                string food1_katti2 = katti.Text;
                string katti_Type2 = katti_box.Text;
                string katti_Quantity3 = katti_display.Text;
                int katti_Quantity4 = int.Parse(katti_Quantity3);
                total_katti = (total_katti * 1) - katti_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_katti2 + "' and Type='" + katti_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", katti_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_katti);
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
        //for samosa
        int samosa_veg = 0;
        int samosa_chicken = 0;
        int total_samosa = 0;
        int countVS3P = 0;
        int countCS3P = 0;
        //
        private void button16_Click(object sender, EventArgs e)//add samosa
        {
            if (samosa_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an iteam", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string)samosa_box.SelectedItem == "Veg")
            {
                countVS3P++;
                samosa_veg++;
                samosa_display.Text = samosa_veg.ToString();
            }

            else if ((string)samosa_box.SelectedItem == "Chicken")
            {
                countCS3P++;
                samosa_chicken++;
                samosa_display.Text = samosa_chicken.ToString();
            }
            try
            {
                canteen.Open();


                string samosa_price = GetFoodPrice("Samosa", samosa_box.Text);
                int samosa_price2 = int.Parse(samosa_price);
                string food1_samosa = samosa.Text;
                string samosa_Type = samosa_box.Text;
                string samosa_Quantity = samosa_display.Text;
                int samosa_Quantity2 = int.Parse(samosa_Quantity);
                total_samosa = samosa_price2 * samosa_Quantity2;
                if (countVS3P == 1 || countCS3P == 1)
                {
                    string query = "Insert into food_order (food,Type,Quantity,Price) values (@parameter_food,@parameter_Type,@parameter_Quantity,@parameter_Price)";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_food", food1_samosa);
                    cmd.Parameters.AddWithValue("@parameter_Type", samosa_Type);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", samosa_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_samosa);
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_samosa + "' and Type='" + samosa_Type + "'";
                    SqlCommand cmd = new SqlCommand(query, canteen);
                    cmd.Parameters.AddWithValue("@parameter_Quantity", samosa_Quantity);
                    cmd.Parameters.AddWithValue("@parameter_Price", total_samosa);
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

        private void samosa_box_SelectedIndexChanged(object sender, EventArgs e)//samosa box
        {
            if ((string)samosa_box.SelectedItem == "Veg")
            {


                samosa_display.Text = samosa_veg.ToString();
            }

            else if ((string)samosa_box.SelectedItem == "Chicken")
            {


                samosa_display.Text = samosa_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (samosa_box.SelectedItem == null)
                {
                    samosa_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Samosa", samosa_box.Text);
                    samosa_price.Text = price;
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

        private void button15_Click(object sender, EventArgs e)//remove samosa
        {
            string samosa_quantity3 = samosa_display.Text;
            int samosa_quantity4 = int.Parse(samosa_quantity3);
            if (samosa_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)samosa_box.SelectedItem == "Veg")
                {

                    samosa_veg--;
                    samosa_display.Text = samosa_veg.ToString();
                }

                else if ((string)samosa_box.SelectedItem == "Chicken")
                {

                    samosa_chicken--;
                    samosa_display.Text = samosa_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string samosa_price3 = GetFoodPrice("Samosa", samosa_box.Text);
                int samosa_price4 = int.Parse(samosa_price3);


                string food1_samosa2 = samosa.Text;
                string samosa_Type2 = samosa_box.Text;
                string samosa_Quantity3 = samosa_display.Text;
                int samosa_Quantity4 = int.Parse(samosa_Quantity3);
                total_samosa = (total_samosa * 1) - samosa_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_samosa2 + "' and Type='" + samosa_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", samosa_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_samosa);
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

        private void momo_box1_SelectedIndexChanged_1(object sender, EventArgs e)//momo box
        {
            if ((string)momo_box1.SelectedItem == "Veg")
            {


                momo_display.Text = momo_veg.ToString();
            }
            else if ((string)momo_box1.SelectedItem == "Buff")
            {


                momo_display.Text = momo_buff.ToString();
            }
            else if ((string)momo_box1.SelectedItem == "Chicken")
            {


                momo_display.Text = momo_chicken.ToString();
            }
            try
            {
                canteen.Open();


                if (momo_box1.SelectedItem == null)
                {
                    momo_price.Text = 0.ToString();
                }
                else
                {
                    string price = GetFoodPrice("Momo", momo_box1.Text);
                    momo_price.Text = price;
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

        private void momoremove_Click_1(object sender, EventArgs e)
        {
            string momo_quantity3 = momo_display.Text;
            int momo_quantity4 = int.Parse(momo_quantity3);
            if (momo_quantity4 <= 0)
            {
                MessageBox.Show("Invalid Value", "Canteen Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((string)momo_box1.SelectedItem == "Veg")
                {

                    momo_veg--;
                    momo_display.Text = momo_veg.ToString();
                }
                else if ((string)momo_box1.SelectedItem == "Buff")
                {

                    momo_buff--;
                    momo_display.Text = momo_buff.ToString();
                }
                else if ((string)momo_box1.SelectedItem == "Chicken")
                {

                    momo_chicken--;
                    momo_display.Text = momo_chicken.ToString();
                }
            }
            try
            {


                canteen.Open();
                string momo_price3 = GetFoodPrice("Momo", momo_box1.Text);
                int momo_price4 = int.Parse(momo_price3);


                string food1_momo2 = momo.Text;
                string momo_Type2 = momo_box1.Text;
                string momo_Quantity3 = momo_display.Text;
                int momo_Quantity4 = int.Parse(momo_Quantity3);
                total_momo = (total_momo * 1) - momo_price4;
                string query = "Update food_order set Quantity=@parameter_Quantity,Price=@parameter_Price where food='" + food1_momo2 + "' and Type='" + momo_Type2 + "'";
                SqlCommand cmd = new SqlCommand(query, canteen);
                cmd.Parameters.AddWithValue("@parameter_Quantity", momo_Quantity3);
                cmd.Parameters.AddWithValue("@parameter_Price", total_momo);
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
    }
}
