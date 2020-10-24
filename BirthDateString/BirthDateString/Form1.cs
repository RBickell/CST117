using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDateString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            String output;
            output = DayOfWeekTextbox.Text + ", " + MonthTextbox.Text + " " + DayOfMonthTextbox.Text + ", " + YearTextbox.Text;
            DateOutputLabel.Text = output;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DayOfWeekTextbox.Text = "";
            MonthTextbox.Text = "";
            DayOfMonthTextbox.Text = "";
            YearTextbox.Text = "";
            DateOutputLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
