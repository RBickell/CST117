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

//Summary
// This code hold the Delete Inventory code.  The code consists of the following: Form load and Button click code

namespace MilestoneProjectCST117__InventoryList
{

    public partial class FrmDeleteInventory : Form
    {
       public FrmDeleteInventory()
        {
            InitializeComponent();
        }

        // Form Load code:
        private void FrmDeleteInventory_Load(object sender, EventArgs e)
        {
            Product.BindDataGridViewToList(DGVInputDeleteInventory);
        }

        //Button Click code:
        private void BtnDeletefromInventory_Click(object sender, EventArgs e)
        {
            int ct = Program.LstPrd.Count;
            List<DataGridViewRow> LstPrd = new List<DataGridViewRow>();
            int rowIndex = DGVInputDeleteInventory.CurrentCell.RowIndex;
            
            Program.LstPrd.RemoveAt(rowIndex);

            if (Program.LstPrd.Count < ct)
            {
                MessageBox.Show("Product(s) has been Deleted", "Success", MessageBoxButtons.OK);
            }
            Product.BindDataGridViewToList(DGVInputDeleteInventory);
        }

        private void BtnCloseFrmDeleteInventory_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var headers = DGVInputDeleteInventory.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

             foreach (DataGridViewRow row in DGVInputDeleteInventory.Rows)
             {
            var cells = row.Cells.Cast<DataGridViewCell>();
             sb.AppendLine(string.Join(",", cells.Select(cell =>  cell.Value ).ToArray()));
             }
            File.WriteAllText(Program.inputfile, sb.ToString());                
            this.Close();
        }

       
    }
}






    

