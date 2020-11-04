namespace Excersie6__Dice_roll
{
    partial class DiceGame
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
            this.RollButton = new System.Windows.Forms.Button();
            this.Dice2Label = new System.Windows.Forms.Label();
            this.Dice1Label = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(44, 234);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(184, 53);
            this.RollButton.TabIndex = 0;
            this.RollButton.Text = "Roll Dice";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // Dice2Label
            // 
            this.Dice2Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dice2Label.Location = new System.Drawing.Point(390, 45);
            this.Dice2Label.Name = "Dice2Label";
            this.Dice2Label.Size = new System.Drawing.Size(95, 95);
            this.Dice2Label.TabIndex = 1;
            // 
            // Dice1Label
            // 
            this.Dice1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dice1Label.Location = new System.Drawing.Point(199, 45);
            this.Dice1Label.Name = "Dice1Label";
            this.Dice1Label.Size = new System.Drawing.Size(95, 95);
            this.Dice1Label.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(483, 234);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(152, 53);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(279, 234);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(153, 53);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Reset";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MessageTextBox.Location = new System.Drawing.Point(178, 167);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(333, 24);
            this.MessageTextBox.TabIndex = 5;
            // 
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(694, 329);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Dice1Label);
            this.Controls.Add(this.Dice2Label);
            this.Controls.Add(this.RollButton);
            this.Name = "DiceGame";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.DiceGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label Dice2Label;
        private System.Windows.Forms.Label Dice1Label;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox MessageTextBox;
    }
}

