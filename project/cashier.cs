using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Select_mode sc = new Select_mode();
            this.Hide();
            sc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            food_design1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drinks_design1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bakery_design1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bill_design1.BringToFront();
        }
    }
}
