using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double LoanAmount;
                double rate;
                double Crate;
                double Irate;
                double Term;
                double PaymentAMT;
                double EndBal;
                double BalRate;
                double Prince;
                double Factor;

                LoanAmount = double.Parse(StartAmountLabel.Text);
                rate = double.Parse(RateLabel.Text);
                Crate = double.Parse(CRatelabel.Text);
                Term = double.Parse(Termtextbox.Text);
                Irate = ((rate / Crate) / 100);
                Factor = (Irate + (Irate / (Math.Pow(Irate + 1, Term) - 1)));
                
                PaymentAMT = (LoanAmount * Factor);
                PaymentLabel.Text = PaymentAMT.ToString();
                EndBal = LoanAmount;

                for (int count = 1; count <= Term; count++)
                {
                    BalRate = PaymentAMT * Irate;
                    Prince = PaymentAMT - BalRate;
                    EndBal = EndBal - Prince;
                    DetaillistBox.Items.Add("The ending Balance for month " + count + "is " + EndBal.ToString("c"));
                }
                Numbox.Text = Term.ToString();
                MessageBox.Show("Calculation is completed");
            }
            catch
            {
                MessageBox.Show("Invalid data was entered");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            StartAmountLabel.Text = "";
            RateLabel.Text = "";
            Termtextbox.Text = "";
            PaymentLabel.Text = "";
            Numbox.Text = "";
            DetaillistBox.Items.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
