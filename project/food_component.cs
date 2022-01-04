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
    public partial class food_component : UserControl
    {
        public String title_name;
        public String[] food_type = { "Select" };
        public food_component()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            cb_type.DataSource = null;
            cb_type.Items.Clear();
            //cb_type.Items.AddRange(food_type);
            foreach (String type in food_type)
            {
                cb_type.Items.Add(type);
            }
            title.Text = title_name;
        }
    }
}
