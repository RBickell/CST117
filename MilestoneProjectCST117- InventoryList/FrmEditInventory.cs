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

namespace MilestoneProjectCST117__InventoryList
{
    public partial class FrmEditInventory : Form
    {
        public FrmEditInventory()
        {
            InitializeComponent();
        }
        string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\MilestoneProjectCST117- InventoryList\\ProductStorage.csv";
        DataTable tbl = new DataTable();
        int NID;
        int indexRow;

        private void BtnLoadEditScreen_Click(object sender, EventArgs e)
        {
            string[] file = File.ReadAllLines(inputfile);
            string[] data_col = null;
            int x = 0;
            tbl.Columns.Add("ID", typeof(Int32));
            tbl.Columns.Add("Product Name");
            tbl.Columns.Add("Category");
            tbl.Columns.Add("Price", typeof(Decimal));
            tbl.Columns.Add("Total In Stock", typeof(Int32));
            tbl.Columns.Add("Cost In Stock", typeof(Decimal));

            foreach (string line in file)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                data_col = line.Split(',');
                DataRow row = tbl.NewRow();
                int N = Convert.ToInt32(data_col[0]);
                if (N > NID)
                {
                    NID = N;
                }
                row["ID"] = N;
                row["Product Name"] = Convert.ToString(data_col[1]);
                row["Category"] = Convert.ToString(data_col[2]);
                row["Price"] = Convert.ToDecimal(data_col[3]);
                row["Total In Stock"] = Convert.ToInt32(data_col[4]);
                row["Cost In Stock"] = Convert.ToDecimal(data_col[5]);
                tbl.Rows.Add(row);
            }
            DGVInputEditInventory.AutoGenerateColumns = false;
            DGVInputEditInventory.DataSource = tbl;
            this.Controls.Add(DGVInputEditInventory);
        }

        private void BtnEditClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var headers = DGVInputEditInventory.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

            foreach (DataGridViewRow row in DGVInputEditInventory.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
            }
            System.IO.File.WriteAllText(inputfile, sb.ToString());
            MessageBox.Show("Change have been Saved");
        }

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
        }

        private void NUDEditInStock_ValueChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[4].Value = NUDEditInStock.Value;
            newDataRow.Cells[5].Value = NUDPrice.Value * NUDEditInStock.Value;
        }

        private void NUDEditCostInStock_ValueChanged(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = DGVInputEditInventory.Rows[indexRow];
            newDataRow.Cells[5].Value = NUDPrice.Value * NUDEditInStock.Value;

        }

        private void DGVInputEditInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVInputEditInventory.SelectedRows.Count == 0)
            {
                return;
            }
            indexRow = DGVInputEditInventory.SelectedRows[0].Index;
            DataGridViewRow row = DGVInputEditInventory.Rows[indexRow];

            TBProductID.Text = row.Cells[0].Value.ToString();
            TBProductName.Text = row.Cells[1].Value.ToString();
            TBCategory.Text = row.Cells[2].Value.ToString();
            NUDPrice.Value = Convert.ToDecimal(row.Cells[3].Value);
            NUDEditInStock.Value = Convert.ToInt32(row.Cells[4].Value);
            NUDEditCostInStock.Value = Convert.ToDecimal(row.Cells[5].Value);
        }

        private void FrmEditInventory_Load(object sender, EventArgs e)
        {
            tbl = Program.PopulateDataTable();
            DGVInputEditInventory.DataSource = tbl;
        }
    }
}
