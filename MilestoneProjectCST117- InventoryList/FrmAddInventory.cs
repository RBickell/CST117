using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Summary:
// This screen holds the button click code for the Add Inventory screen
namespace MilestoneProjectCST117__InventoryList
{

    public partial class FrmAddInventory : Form
    {
        public FrmAddInventory()
        {
            InitializeComponent();
        }
        
        //Declaration code:
        private int NID;

        
        //Button Click code:
        private void BtnAddInventory_Click(object sender, EventArgs e)
        {
            int ct = Program.LstPrd.Count;
            Product prd = new Product(Product.GetNewID(), TBProductName.Text, TBCategory.Text, NUDPrice.Value, NUDAddStock.Value, NUDPrice.Value * NUDAddStock.Value);
            Program.LstPrd.Add(prd);


            if (Program.LstPrd.Count > ct)
            {
                MessageBox.Show("Product has been added", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Product not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TBProductName.Clear();
            TBCategory.Clear();
            NUDPrice.Value = 0;
            NUDAddStock.Value = 0;
            File.AppendAllText(Program.inputfile, System.Environment.NewLine + Convert.ToString(prd.ID) + "," + prd.ProductName + "," + prd.Category + "," + Convert.ToString(prd.Price) + "," + Convert.ToString(prd.AddInStock) + "," + Convert.ToString(prd.CostInStock));

        }
        private void btnCloseAddScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
