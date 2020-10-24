using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project__Inventory_List
{
    public partial class Form1 : Form
    {
           public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
                ProductSearchbox.Items.Add("Select Product");
                ProductSearchbox.Items.Add("Chairs");
                ProductSearchbox.Items.Add("CPU: Dell");
                ProductSearchbox.Items.Add("CPU: HP");
                ProductSearchbox.Items.Add("Desks");
                ProductSearchbox.Items.Add("Ethernet Cord");
                ProductSearchbox.Items.Add("Headsets");
                ProductSearchbox.Items.Add("Keyboards");
                ProductSearchbox.Items.Add("Monitors");
                ProductSearchbox.Items.Add("Mouse");
                ProductSearchbox.Items.Add("Phones");
                ProductSearchbox.Items.Add("Power strips");
                ProductSearchbox.Items.Add("TV:36in");
                ProductSearchbox.Items.Add("VDI Cord");

                CategorySearchBox.Items.Add("Select Category");
                CategorySearchBox.Items.Add("Computer");
                CategorySearchBox.Items.Add("Cords");
                CategorySearchBox.Items.Add("Furniture");
                CategorySearchBox.Items.Add("Headsets");
                CategorySearchBox.Items.Add("Phones");
                CategorySearchBox.Items.Add("PowerStrips");
                CategorySearchBox.Items.Add("TVs");

                PriceSearchBox.Items.Add("Select Price");
                PriceSearchBox.Items.Add("0.84");
                PriceSearchBox.Items.Add("9.88");
                PriceSearchBox.Items.Add("13.99");
                PriceSearchBox.Items.Add("19.99");
                PriceSearchBox.Items.Add("24.99");
                PriceSearchBox.Items.Add("25.95");
                PriceSearchBox.Items.Add("79.99");
                PriceSearchBox.Items.Add("98.97");
                PriceSearchBox.Items.Add("196.00");
                PriceSearchBox.Items.Add("375.00");
                PriceSearchBox.Items.Add("495.00");
                PriceSearchBox.Items.Add("579.00");
                PriceSearchBox.Items.Add("799.00");

                FirstSortbyBox.Items.Add("Select");
                FirstSortbyBox.Items.Add("Category");
                FirstSortbyBox.Items.Add("In Use");
                FirstSortbyBox.Items.Add("Availability");
                FirstSortbyBox.Items.Add("Price");
                
                SecondSortByBox.Items.Add("Select");
                SecondSortByBox.Items.Add("Category");
                SecondSortByBox.Items.Add("In Use");
                SecondSortByBox.Items.Add("Availability");
                SecondSortByBox.Items.Add("Price");


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}

    

