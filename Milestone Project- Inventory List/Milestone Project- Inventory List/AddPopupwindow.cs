using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Milestone_Project__Inventory_List
{
    public partial class AddPopupwindow : Form
    {
        public AddPopupwindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategorycomboBox.Items.Add("Choose Item");
            CategorycomboBox.Items.Add("Computer");
            CategorycomboBox.Items.Add("Cords");
            CategorycomboBox.Items.Add("Furniture");
            CategorycomboBox.Items.Add("Headset");
            CategorycomboBox.Items.Add("Phone");
            CategorycomboBox.Items.Add("Powerstrips");
            CategorycomboBox.Items.Add("TVs");
        }
    }
}
