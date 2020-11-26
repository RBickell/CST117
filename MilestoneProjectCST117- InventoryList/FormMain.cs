using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


//Summary
//The code consists of the following: Form load, button click loads, Textboxes changed, and DataSource changed.
namespace MilestoneProjectCST117__InventoryList
{
    public partial class FormMain : Form
    {
        private int NID;

        public ListView dt = new ListView();




        public FormMain()
        {
            InitializeComponent();
        }

        //Form Load code:
        private void FormMain_Load(object sender, EventArgs e)
        {
            DGVInput.AutoGenerateColumns = false;
            string[] strarr = File.ReadAllLines(Program.inputfile);
            foreach (string s in strarr)
            {
                if (s == strarr[0])
                {
                    continue;
                }
                string[] sa = s.Split(',');
                Program.LstPrd.Add(new Product(Convert.ToInt32(sa[0]), sa[1], sa[2], Convert.ToDecimal(sa[3]), Convert.ToDecimal(sa[4]), Convert.ToDecimal(sa[5])));
            }
            Product.BindDataGridViewToList(DGVInput);
        }

        //Button Click Code:
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            FrmAddInventory AddInv = new FrmAddInventory();
            AddInv.ShowDialog();
            Product.BindDataGridViewToList(DGVInput);

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBProductID.Text = "";
            TBProductName.Text = "";
            TBCategory.Text = "";
            Product.BindDataGridViewToList(DGVInput);
        }

        private void DeleteInvButton_Click(object sender, EventArgs e)
        {
            FrmDeleteInventory DeleteInv = new FrmDeleteInventory();
            DeleteInv.ShowDialog();
            Product.BindDataGridViewToList(DGVInput);

        }

        private void EditInvButton_Click(object sender, EventArgs e)
        {
            FrmEditInventory editInv = new FrmEditInventory();
            editInv.ShowDialog();
            Product.BindDataGridViewToList(DGVInput);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string sSearch;
            var list = Program.LstPrd;
            var result = list.ToList();
            

            if (TBProductID.TextLength > 0)
            {
                int N;
                int CT = 0;
                
                if (Int32.TryParse(TBProductID.Text, out N))
                {
                    for (int i = 0; i < Program.LstPrd.Count; i++)
                    {
                        if (Program.LstPrd[i].ID.Equals(N))
                        {
                            result = Program.LstPrd.Where(r => r.ID == N).ToList();
                            CT++;

                        }
                    }

                    if (CT > 0)
                    {
                        DGVInput.DataSource = result;
                    }
                    else
                    {
                        MessageBox.Show("No records found");
                    }

                }
                else
                {
                    MessageBox.Show("Product ID has to be a whole number");
                    Product.BindDataGridViewToList(DGVInput);
                    return;
                }
            }

            int YT = 0;
            if (TBProductName.TextLength > 0)
            {
                sSearch = TBProductName.Text;
                

                for (int i = 0; i < Program.LstPrd.Count; i++)
                {
                    if (Program.LstPrd[i].ProductName.Equals(sSearch))
                    {
                        result = Program.LstPrd.Where(r => r.ProductName == sSearch).ToList();
                        YT++;

                    }
                }

                if (YT > 0)
                {
                    DGVInput.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No records found");
                }
            }

            int ZT = 0;
            if (TBCategory.TextLength > 0)
            {
                sSearch = TBCategory.Text;

                
                for (int i = 0; i < Program.LstPrd.Count; i++)
                {
                    if (Program.LstPrd[i].Category.Equals(sSearch))
                    {
                        result = Program.LstPrd.Where(r => r.Category == sSearch).ToList();
                        ZT++;
                    }
                }

                if (ZT > 0)
                {
                    DGVInput.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No records found");
                }
            }
        }
        
        //TextBox Changed Code:
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

        //DataSource Changed Code:
        private void DGVInput_DataSourceChanged(object sender, EventArgs e)
        {
            SSLbl.Text = DGVInput.Rows.Count + " Records found";
        }

       
    }
}

