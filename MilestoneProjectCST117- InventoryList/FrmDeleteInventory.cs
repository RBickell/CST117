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

    public partial class FrmDeleteInventory : Form
    {
        string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\MilestoneProjectCST117- InventoryList\\ProductStorage.csv";
        private int NID;
        DataTable tbl = new DataTable();


        public FrmDeleteInventory()
        {
            InitializeComponent();
        }
        

        private void BtnDeletefromInventory_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> lst = new List<DataGridViewRow>();
            foreach (DataGridViewRow dgvr in DGVInputDeleteInventory.SelectedRows)
            {
                lst.Add(dgvr);
            }
            for (int i =0;i<lst.Count;i++)
            {
                DGVInputDeleteInventory.Rows.Remove(lst[i]);
            }
            //int rowIndex = DGVInputDeleteInventory.CurrentCell.RowIndex;
            
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            
            DGVInputDeleteInventory.AutoGenerateColumns = false;
            DGVInputDeleteInventory.DataSource = tbl;
            
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
                File.WriteAllText(inputfile, sb.ToString());                
                this.Close();
        }

        private void FrmDeleteInventory_Load(object sender, EventArgs e)
        {
            tbl = Program.PopulateDataTable();
            DGVInputDeleteInventory.AutoGenerateColumns = false;
            DGVInputDeleteInventory.DataSource = tbl;
            
        }
    }
}






    

