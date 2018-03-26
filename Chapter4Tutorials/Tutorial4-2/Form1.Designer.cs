namespace Tutorial4_2
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
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.hourlyPayrateLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.grossPayOutputLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(43, 20);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Hours worked:";
            // 
            // hourlyPayrateLabel
            // 
            this.hourlyPayrateLabel.AutoSize = true;
            this.hourlyPayrateLabel.Location = new System.Drawing.Point(43, 54);
            this.hourlyPayrateLabel.Name = "hourlyPayrateLabel";
            this.hourlyPayrateLabel.Size = new System.Drawing.Size(81, 13);
            this.hourlyPayrateLabel.TabIndex = 1;
            this.hourlyPayrateLabel.Text = "Hourly pay rate:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(62, 96);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(57, 13);
            this.grossPayLabel.TabIndex = 2;
            this.grossPayLabel.Text = "Gross pay:";
            // 
            // grossPayOutputLabel
            // 
            this.grossPayOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayOutputLabel.Location = new System.Drawing.Point(127, 86);
            this.grossPayOutputLabel.Name = "grossPayOutputLabel";
            this.grossPayOutputLabel.Size = new System.Drawing.Size(157, 23);
            this.grossPayOutputLabel.TabIndex = 3;
            this.grossPayOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(130, 13);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(154, 20);
            this.hoursWorkedTextBox.TabIndex = 4;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(130, 47);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(154, 20);
            this.hourlyPayRateTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 183);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calcuate Gross Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(149, 183);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(59, 35);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(267, 183);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 234);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.grossPayOutputLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hourlyPayrateLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Name = "Form1";
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label hourlyPayrateLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label grossPayOutputLabel;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

