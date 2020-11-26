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

// Summary
//This code holds the Edit Inventory code. The code consists of the following: Declarations of variables, Form load, Button clicks, and Textbox and num up and down text/value changed

namespace MilestoneProjectCST117__InventoryList
{
    public partial class FrmEditInventory : Form
    {
        public FrmEditInventory()
        {
            InitializeComponent();
        }
        
        //Declaration of variables
        int NID;
        int indexRow;

        //Form load code:
        private void FrmEditInventory_Load(object sender, EventArgs e)
        {
            Product.BindDataGridViewToList(DGVInputEditInventory);
            DGVInputEditInventory.CurrentCell = null;

        }



        private void BtnEditClose_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }
               

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Product.ProductDetails.ProductItems Prd = new Product.ProductDetails.ProductItems();
            var sb = new StringBuilder();
            var headers = DGVInputEditInventory.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

            foreach (DataGridViewRow row in DGVInputEditInventory.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));

            }
            System.IO.File.WriteAllText(Program.inputfile, Convert.ToString(sb));
            MessageBox.Show("Change have been Saved");
        }

        // Textbox and Num up and down Text/Value changed

        private void TBProductID_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[0].Value = TBProductID.Text;
        }

        private void TBProductName_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[1].Value = TBProductName.Text;
        }

        private void TBCategory_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[2].Value = TBCategory.Text;
        }

        private void NUDPrice_ValueChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[3].Value = NUDPrice.Value;
            newDataRow.Cells[5].Value = NUDPrice.Value * NUDEditInStock.Value;
            NUDEditCostInStock.Value= NUDPrice.Value * NUDEditInStock.Value;
        }

        private void NUDEditInStock_ValueChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[4].Value = NUDEditInStock.Value;
            newDataRow.Cells[5].Value = NUDPrice.Value * NUDEditInStock.Value;
            NUDEditCostInStock.Value = NUDPrice.Value * NUDEditInStock.Value;
        }

        private void DGVInputEditInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVInputEditInventory.SelectedRows.Count == 0)
            {
                return;
            }
            indexRow = DGVInputEditInventory.SelectedRows[0].Index;
            DataGridViewRow row = DGVInputEditInventory.Rows[indexRow];

            TBProductID.Text = Convert.ToString(row.Cells[0].Value);
            TBProductName.Text = Convert.ToString(row.Cells[1].Value);
            TBCategory.Text = Convert.ToString(row.Cells[2].Value);
            NUDPrice.Value = Convert.ToDecimal(row.Cells[3].Value);
            NUDEditInStock.Value = Convert.ToDecimal(row.Cells[4].Value);
            NUDEditCostInStock.Value = Convert.ToDecimal(row.Cells[5].Value);
        }

       
    }
}
