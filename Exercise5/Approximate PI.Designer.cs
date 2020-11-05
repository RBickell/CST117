namespace Exercise5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TermsLabel = new System.Windows.Forms.Label();
            this.Termtextbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Numbox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.TextBox();
            this.LoanBalance = new System.Windows.Forms.Label();
            this.StartAmountLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FormTitle = new System.Windows.Forms.Label();
            this.DetaillistBox = new System.Windows.Forms.ListBox();
            this.CRatelabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TermsLabel
            // 
            this.TermsLabel.AutoSize = true;
            this.TermsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsLabel.Location = new System.Drawing.Point(39, 189);
            this.TermsLabel.Name = "TermsLabel";
            this.TermsLabel.Size = new System.Drawing.Size(189, 19);
            this.TermsLabel.TabIndex = 0;
            this.TermsLabel.Text = "Enter # of  Months (Term):";
            // 
            // Termtextbox
            // 
            this.Termtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Termtextbox.Location = new System.Drawing.Point(234, 185);
            this.Termtextbox.Name = "Termtextbox";
            this.Termtextbox.Size = new System.Drawing.Size(100, 26);
            this.Termtextbox.TabIndex = 1;
            this.Termtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(42, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 15);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Number of Months";
            // 
            // Numbox
            // 
            this.Numbox.BackColor = System.Drawing.SystemColors.Menu;
            this.Numbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numbox.Location = new System.Drawing.Point(153, 258);
            this.Numbox.Name = "Numbox";
            this.Numbox.ReadOnly = true;
            this.Numbox.Size = new System.Drawing.Size(53, 15);
            this.Numbox.TabIndex = 3;
            this.Numbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox4.Location = new System.Drawing.Point(212, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 15);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "interest was paid.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(285, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 47);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(163, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 48);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestLabel.Location = new System.Drawing.Point(39, 117);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(174, 20);
            this.InterestLabel.TabIndex = 11;
            this.InterestLabel.Text = "Interest Percentage:";
            // 
            // RateLabel
            // 
            this.RateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateLabel.Location = new System.Drawing.Point(234, 114);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(100, 26);
            this.RateLabel.TabIndex = 12;
            // 
            // LoanBalance
            // 
            this.LoanBalance.AutoSize = true;
            this.LoanBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanBalance.Location = new System.Drawing.Point(39, 79);
            this.LoanBalance.Name = "LoanBalance";
            this.LoanBalance.Size = new System.Drawing.Size(116, 20);
            this.LoanBalance.TabIndex = 13;
            this.LoanBalance.Text = "Loan Amount";
            // 
            // StartAmountLabel
            // 
            this.StartAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAmountLabel.Location = new System.Drawing.Point(234, 79);
            this.StartAmountLabel.Name = "StartAmountLabel";
            this.StartAmountLabel.Size = new System.Drawing.Size(100, 26);
            this.StartAmountLabel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Compounded  Rate:";
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(37, 20);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(372, 31);
            this.FormTitle.TabIndex = 17;
            this.FormTitle.Text = "Exercise 5: Loan Calculator";
            // 
            // DetaillistBox
            // 
            this.DetaillistBox.FormattingEnabled = true;
            this.DetaillistBox.Location = new System.Drawing.Point(43, 279);
            this.DetaillistBox.Name = "DetaillistBox";
            this.DetaillistBox.Size = new System.Drawing.Size(349, 134);
            this.DetaillistBox.TabIndex = 18;
            // 
            // CRatelabel
            // 
            this.CRatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRatelabel.Location = new System.Drawing.Point(234, 151);
            this.CRatelabel.Name = "CRatelabel";
            this.CRatelabel.ReadOnly = true;
            this.CRatelabel.Size = new System.Drawing.Size(100, 26);
            this.CRatelabel.TabIndex = 19;
            this.CRatelabel.Text = "12";
            this.CRatelabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Payment Amount:";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(234, 221);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.ReadOnly = true;
            this.PaymentLabel.Size = new System.Drawing.Size(100, 26);
            this.PaymentLabel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 586);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CRatelabel);
            this.Controls.Add(this.DetaillistBox);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartAmountLabel);
            this.Controls.Add(this.LoanBalance);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.InterestLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Numbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Termtextbox);
            this.Controls.Add(this.TermsLabel);
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TermsLabel;
        private System.Windows.Forms.TextBox Termtextbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Numbox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.TextBox RateLabel;
        private System.Windows.Forms.Label LoanBalance;
        private System.Windows.Forms.TextBox StartAmountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.ListBox DetaillistBox;
        private System.Windows.Forms.TextBox CRatelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaymentLabel;
    }
}

