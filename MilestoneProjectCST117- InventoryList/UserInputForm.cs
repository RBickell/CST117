using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProjectCST117__InventoryList
{
    public partial class UserInputForm : Form
    {
        FormMain invFrm;
        public UserInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            invFrm = new FormMain();
            invFrm.Show();

        }

        private void buttonCreatInvForm2_Click(object sender, EventArgs e)
        {
            invFrm = new FormMain();
            invFrm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            invFrm.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Add(2, 6);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Calculator.Sub(2, 5);
            
        }
    }
}
