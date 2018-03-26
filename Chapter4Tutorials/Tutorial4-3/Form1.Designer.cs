namespace Tutorial4_3
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
            this.annualSalaryLabel = new System.Windows.Forms.Label();
            this.yearsCurrentJobLabel = new System.Windows.Forms.Label();
            this.loanDecissionLabel = new System.Windows.Forms.Label();
            this.loanDecissionOutputLabel = new System.Windows.Forms.Label();
            this.yearsCurrentTextBox = new System.Windows.Forms.TextBox();
            this.annualSalaryTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annualSalaryLabel
            // 
            this.annualSalaryLabel.AutoSize = true;
            this.annualSalaryLabel.Location = new System.Drawing.Point(64, 35);
            this.annualSalaryLabel.Name = "annualSalaryLabel";
            this.annualSalaryLabel.Size = new System.Drawing.Size(75, 13);
            this.annualSalaryLabel.TabIndex = 0;
            this.annualSalaryLabel.Text = "Annual Salary:";
            // 
            // yearsCurrentJobLabel
            // 
            this.yearsCurrentJobLabel.AutoSize = true;
            this.yearsCurrentJobLabel.Location = new System.Drawing.Point(37, 65);
            this.yearsCurrentJobLabel.Name = "yearsCurrentJobLabel";
            this.yearsCurrentJobLabel.Size = new System.Drawing.Size(102, 13);
            this.yearsCurrentJobLabel.TabIndex = 1;
            this.yearsCurrentJobLabel.Text = "Years at current job:";
            // 
            // loanDecissionLabel
            // 
            this.loanDecissionLabel.AutoSize = true;
            this.loanDecissionLabel.Location = new System.Drawing.Point(52, 140);
            this.loanDecissionLabel.Name = "loanDecissionLabel";
            this.loanDecissionLabel.Size = new System.Drawing.Size(81, 13);
            this.loanDecissionLabel.TabIndex = 2;
            this.loanDecissionLabel.Text = "Loan decission:";
            // 
            // loanDecissionOutputLabel
            // 
            this.loanDecissionOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanDecissionOutputLabel.Location = new System.Drawing.Point(55, 158);
            this.loanDecissionOutputLabel.Name = "loanDecissionOutputLabel";
            this.loanDecissionOutputLabel.Size = new System.Drawing.Size(212, 33);
            this.loanDecissionOutputLabel.TabIndex = 3;
            this.loanDecissionOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearsCurrentTextBox
            // 
            this.yearsCurrentTextBox.Location = new System.Drawing.Point(156, 58);
            this.yearsCurrentTextBox.Name = "yearsCurrentTextBox";
            this.yearsCurrentTextBox.Size = new System.Drawing.Size(111, 20);
            this.yearsCurrentTextBox.TabIndex = 4;
            // 
            // annualSalaryTextBox
            // 
            this.annualSalaryTextBox.Location = new System.Drawing.Point(156, 32);
            this.annualSalaryTextBox.Name = "annualSalaryTextBox";
            this.annualSalaryTextBox.Size = new System.Drawing.Size(111, 20);
            this.annualSalaryTextBox.TabIndex = 5;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 226);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(111, 23);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check Qualification";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(131, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(239, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.annualSalaryTextBox);
            this.Controls.Add(this.yearsCurrentTextBox);
            this.Controls.Add(this.loanDecissionOutputLabel);
            this.Controls.Add(this.loanDecissionLabel);
            this.Controls.Add(this.yearsCurrentJobLabel);
            this.Controls.Add(this.annualSalaryLabel);
            this.Name = "Form1";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annualSalaryLabel;
        private System.Windows.Forms.Label yearsCurrentJobLabel;
        private System.Windows.Forms.Label loanDecissionLabel;
        private System.Windows.Forms.Label loanDecissionOutputLabel;
        private System.Windows.Forms.TextBox yearsCurrentTextBox;
        private System.Windows.Forms.TextBox annualSalaryTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

