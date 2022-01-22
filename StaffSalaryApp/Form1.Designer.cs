namespace StaffSalaryApp
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
            this.basicSalaryLabel = new System.Windows.Forms.Label();
            this.basicSalaryTextBox = new System.Windows.Forms.TextBox();
            this.totalSalarylabel = new System.Windows.Forms.Label();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.showTotalSalaryButton = new System.Windows.Forms.Button();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // basicSalaryLabel
            // 
            this.basicSalaryLabel.AutoSize = true;
            this.basicSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicSalaryLabel.Location = new System.Drawing.Point(63, 45);
            this.basicSalaryLabel.Name = "basicSalaryLabel";
            this.basicSalaryLabel.Size = new System.Drawing.Size(133, 25);
            this.basicSalaryLabel.TabIndex = 0;
            this.basicSalaryLabel.Text = "Basic Salary";
            // 
            // basicSalaryTextBox
            // 
            this.basicSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicSalaryTextBox.Location = new System.Drawing.Point(252, 45);
            this.basicSalaryTextBox.Name = "basicSalaryTextBox";
            this.basicSalaryTextBox.Size = new System.Drawing.Size(237, 30);
            this.basicSalaryTextBox.TabIndex = 1;
            // 
            // totalSalarylabel
            // 
            this.totalSalarylabel.AutoSize = true;
            this.totalSalarylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalarylabel.Location = new System.Drawing.Point(63, 212);
            this.totalSalarylabel.Name = "totalSalarylabel";
            this.totalSalarylabel.Size = new System.Drawing.Size(129, 25);
            this.totalSalarylabel.TabIndex = 0;
            this.totalSalarylabel.Text = "Total Salary";
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalaryTextBox.Location = new System.Drawing.Point(252, 207);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.ReadOnly = true;
            this.totalSalaryTextBox.Size = new System.Drawing.Size(237, 30);
            this.totalSalaryTextBox.TabIndex = 1;
            // 
            // showTotalSalaryButton
            // 
            this.showTotalSalaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTotalSalaryButton.Location = new System.Drawing.Point(134, 316);
            this.showTotalSalaryButton.Name = "showTotalSalaryButton";
            this.showTotalSalaryButton.Size = new System.Drawing.Size(329, 56);
            this.showTotalSalaryButton.TabIndex = 2;
            this.showTotalSalaryButton.Text = "Show Total Salary";
            this.showTotalSalaryButton.UseVisualStyleBackColor = true;
            this.showTotalSalaryButton.Click += new System.EventHandler(this.showTotalSalaryButton_Click);
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.Location = new System.Drawing.Point(63, 124);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(73, 25);
            this.bonusLabel.TabIndex = 0;
            this.bonusLabel.Text = "Bonus";
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusTextBox.Location = new System.Drawing.Point(252, 124);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.ReadOnly = true;
            this.bonusTextBox.Size = new System.Drawing.Size(237, 30);
            this.bonusTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.showTotalSalaryButton);
            this.Controls.Add(this.totalSalaryTextBox);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.totalSalarylabel);
            this.Controls.Add(this.basicSalaryTextBox);
            this.Controls.Add(this.basicSalaryLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label basicSalaryLabel;
        private System.Windows.Forms.TextBox basicSalaryTextBox;
        private System.Windows.Forms.Label totalSalarylabel;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
        private System.Windows.Forms.Button showTotalSalaryButton;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.TextBox bonusTextBox;
    }
}

