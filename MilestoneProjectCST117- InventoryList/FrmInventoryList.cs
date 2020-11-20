using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace MilestoneProjectCST117__InventoryList
{
    public partial class FrmInventoryList : Form
    {
        private int NID;
        DataTable tbl = new DataTable();
        

        public FrmInventoryList()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetListButton_Click(object sender, EventArgs e)
        {
            tbl=Program.PopulateDataTable();
            DGVInput.AutoGenerateColumns = false;
            DGVInput.DataSource = tbl;
        }

        

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            FrmAddInventory AddInv = new FrmAddInventory();
            AddInv.Show();
            tbl = Program.PopulateDataTable();
            DGVInput.DataSource = tbl;
        }

        private void DeleteInvButton_Click(object sender, EventArgs e)
        {
            FrmDeleteInventory DeleteInv = new FrmDeleteInventory();
            DeleteInv.Show();
            tbl = Program.PopulateDataTable();
            DGVInput.DataSource = tbl;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            tbl = Program.PopulateDataTable();
            

            if (TBProductID.TextLength > 0)
            {
                Int32 N;
                if (Int32.TryParse(TBProductID.Text, out N))
                {
                    EnumerableRowCollection<DataRow> dra = tbl.AsEnumerable()
                                   .Where(r => r.Field<Int32>("ID") == Convert.ToInt32(TBProductID.Text));
                    if (dra.Count() > 0)
                    {
                        tbl = dra.CopyToDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No record found.");
                        tbl.Rows.Clear();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Product ID has to be a whole number");
                    tbl.Rows.Clear();
                    return;
                }
            }
            if (TBProductName.TextLength > 0)
            {
                EnumerableRowCollection<DataRow> dra = tbl.AsEnumerable()
                                   .Where(r => r.Field<string>("Product Name").ToUpper() == TBProductName.Text.ToUpper());
                if (dra.Count() > 0)
                {
                    tbl = dra.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show("No record found.");
                    tbl.Rows.Clear();
                    return;
                }

            }
            if (TBCategory.TextLength > 0)
            {
                EnumerableRowCollection<DataRow> dra = tbl.AsEnumerable()
                               .Where(r => r.Field<string>("Category").ToUpper() == TBCategory.Text.ToUpper());
                if (dra.Count() > 0)
                {
                    tbl = dra.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show("No record found.");
                    tbl.Rows.Clear();
                    return;
                }               
            }
            DGVInput.DataSource = tbl;
        }

        private void EditInvButton_Click(object sender, EventArgs e)
        {
            FrmEditInventory EditInv = new FrmEditInventory();
            EditInv.Show();
            tbl = Program.PopulateDataTable();
            DGVInput.DataSource = tbl;
        }

        private void TBProductID_TextChanged(object sender, EventArgs e)
        {
            if (TBProductID.TextLength > 0)
            {
                TBProductName.Text = "";
                TBCategory.Text = "";
            }
        }

        private void TBProductName_TextChanged(object sender, EventArgs e)
       {
            if (TBProductName.TextLength > 0)
            {
                TBProductID.Text = "";
                TBCategory.Text = "";
            }
        }

        private void TBCategory_TextChanged(object sender, EventArgs e)
        {
            if (TBCategory.TextLength > 0)
            {
                TBProductID.Text = "";
                TBProductName.Text = "";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBProductID.Text = "";
            TBProductName.Text = "";
            TBCategory.Text = "";
            tbl = Program.PopulateDataTable();
            DGVInput.DataSource = tbl;
        }

        private void DGVInput_DataSourceChanged(object sender, EventArgs e)
        {
            SSLbl.Text = DGVInput.Rows.Count + " Records found";
        }
    }
}


