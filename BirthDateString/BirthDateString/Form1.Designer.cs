namespace BirthDateString
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
            this.DayofWeekPromptLabel = new System.Windows.Forms.Label();
            this.MonthPromptLabel = new System.Windows.Forms.Label();
            this.DayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.YearPromptLabel = new System.Windows.Forms.Label();
            this.DayOfWeekTextbox = new System.Windows.Forms.TextBox();
            this.MonthTextbox = new System.Windows.Forms.TextBox();
            this.DayOfMonthTextbox = new System.Windows.Forms.TextBox();
            this.YearTextbox = new System.Windows.Forms.TextBox();
            this.DateOutputLabel = new System.Windows.Forms.Label();
            this.ShowDateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayofWeekPromptLabel
            // 
            this.DayofWeekPromptLabel.AutoSize = true;
            this.DayofWeekPromptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayofWeekPromptLabel.Location = new System.Drawing.Point(88, 29);
            this.DayofWeekPromptLabel.Name = "DayofWeekPromptLabel";
            this.DayofWeekPromptLabel.Size = new System.Drawing.Size(210, 18);
            this.DayofWeekPromptLabel.TabIndex = 0;
            this.DayofWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // MonthPromptLabel
            // 
            this.MonthPromptLabel.AutoSize = true;
            this.MonthPromptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthPromptLabel.Location = new System.Drawing.Point(65, 64);
            this.MonthPromptLabel.Name = "MonthPromptLabel";
            this.MonthPromptLabel.Size = new System.Drawing.Size(233, 18);
            this.MonthPromptLabel.TabIndex = 1;
            this.MonthPromptLabel.Text = "Enter the name of the month";
            // 
            // DayOfMonthPromptLabel
            // 
            this.DayOfMonthPromptLabel.AutoSize = true;
            this.DayOfMonthPromptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfMonthPromptLabel.Location = new System.Drawing.Point(12, 97);
            this.DayOfMonthPromptLabel.Name = "DayOfMonthPromptLabel";
            this.DayOfMonthPromptLabel.Size = new System.Drawing.Size(286, 18);
            this.DayOfMonthPromptLabel.TabIndex = 2;
            this.DayOfMonthPromptLabel.Text = "Enter the numeric day of the Month";
            // 
            // YearPromptLabel
            // 
            this.YearPromptLabel.AutoSize = true;
            this.YearPromptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearPromptLabel.Location = new System.Drawing.Point(176, 130);
            this.YearPromptLabel.Name = "YearPromptLabel";
            this.YearPromptLabel.Size = new System.Drawing.Size(122, 18);
            this.YearPromptLabel.TabIndex = 3;
            this.YearPromptLabel.Text = "Enter the year";
            // 
            // DayOfWeekTextbox
            // 
            this.DayOfWeekTextbox.Location = new System.Drawing.Point(321, 31);
            this.DayOfWeekTextbox.Name = "DayOfWeekTextbox";
            this.DayOfWeekTextbox.Size = new System.Drawing.Size(117, 20);
            this.DayOfWeekTextbox.TabIndex = 4;
            // 
            // MonthTextbox
            // 
            this.MonthTextbox.Location = new System.Drawing.Point(321, 65);
            this.MonthTextbox.Name = "MonthTextbox";
            this.MonthTextbox.Size = new System.Drawing.Size(116, 20);
            this.MonthTextbox.TabIndex = 5;
            // 
            // DayOfMonthTextbox
            // 
            this.DayOfMonthTextbox.Location = new System.Drawing.Point(323, 100);
            this.DayOfMonthTextbox.Name = "DayOfMonthTextbox";
            this.DayOfMonthTextbox.Size = new System.Drawing.Size(113, 20);
            this.DayOfMonthTextbox.TabIndex = 6;
            // 
            // YearTextbox
            // 
            this.YearTextbox.Location = new System.Drawing.Point(323, 132);
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.Size = new System.Drawing.Size(112, 20);
            this.YearTextbox.TabIndex = 7;
            // 
            // DateOutputLabel
            // 
            this.DateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateOutputLabel.Location = new System.Drawing.Point(12, 170);
            this.DateOutputLabel.Name = "DateOutputLabel";
            this.DateOutputLabel.Size = new System.Drawing.Size(426, 30);
            this.DateOutputLabel.TabIndex = 8;
            this.DateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowDateButton
            // 
            this.ShowDateButton.Location = new System.Drawing.Point(35, 214);
            this.ShowDateButton.Name = "ShowDateButton";
            this.ShowDateButton.Size = new System.Drawing.Size(110, 43);
            this.ShowDateButton.TabIndex = 9;
            this.ShowDateButton.Text = "Show Date";
            this.ShowDateButton.UseVisualStyleBackColor = true;
            this.ShowDateButton.Click += new System.EventHandler(this.ShowDateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(179, 214);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(105, 43);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(321, 214);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 43);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowDateButton);
            this.Controls.Add(this.DateOutputLabel);
            this.Controls.Add(this.YearTextbox);
            this.Controls.Add(this.DayOfMonthTextbox);
            this.Controls.Add(this.MonthTextbox);
            this.Controls.Add(this.DayOfWeekTextbox);
            this.Controls.Add(this.YearPromptLabel);
            this.Controls.Add(this.DayOfMonthPromptLabel);
            this.Controls.Add(this.MonthPromptLabel);
            this.Controls.Add(this.DayofWeekPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayofWeekPromptLabel;
        private System.Windows.Forms.Label MonthPromptLabel;
        private System.Windows.Forms.Label DayOfMonthPromptLabel;
        private System.Windows.Forms.Label YearPromptLabel;
        private System.Windows.Forms.TextBox DayOfWeekTextbox;
        private System.Windows.Forms.TextBox MonthTextbox;
        private System.Windows.Forms.TextBox DayOfMonthTextbox;
        private System.Windows.Forms.TextBox YearTextbox;
        private System.Windows.Forms.Label DateOutputLabel;
        private System.Windows.Forms.Button ShowDateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

