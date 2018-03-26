namespace Tutorial4_4
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
            this.numberOfMilesDrivenLabel = new System.Windows.Forms.Label();
            this.gllonOfGasUsedLabel = new System.Windows.Forms.Label();
            this.carsMPGLabel = new System.Windows.Forms.Label();
            this.carsMPGOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gallonOfGasUsedTextBox = new System.Windows.Forms.TextBox();
            this.numberOfMilesDrivenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberOfMilesDrivenLabel
            // 
            this.numberOfMilesDrivenLabel.AutoSize = true;
            this.numberOfMilesDrivenLabel.Location = new System.Drawing.Point(37, 41);
            this.numberOfMilesDrivenLabel.Name = "numberOfMilesDrivenLabel";
            this.numberOfMilesDrivenLabel.Size = new System.Drawing.Size(161, 13);
            this.numberOfMilesDrivenLabel.TabIndex = 0;
            this.numberOfMilesDrivenLabel.Text = "Enter the number of miles driven:";
            // 
            // gllonOfGasUsedLabel
            // 
            this.gllonOfGasUsedLabel.AutoSize = true;
            this.gllonOfGasUsedLabel.Location = new System.Drawing.Point(55, 77);
            this.gllonOfGasUsedLabel.Name = "gllonOfGasUsedLabel";
            this.gllonOfGasUsedLabel.Size = new System.Drawing.Size(142, 13);
            this.gllonOfGasUsedLabel.TabIndex = 1;
            this.gllonOfGasUsedLabel.Text = "Enter the gallon of gas used:";
            // 
            // carsMPGLabel
            // 
            this.carsMPGLabel.AutoSize = true;
            this.carsMPGLabel.Location = new System.Drawing.Point(114, 134);
            this.carsMPGLabel.Name = "carsMPGLabel";
            this.carsMPGLabel.Size = new System.Drawing.Size(80, 13);
            this.carsMPGLabel.TabIndex = 2;
            this.carsMPGLabel.Text = "Your car\'s mpg:";
            // 
            // carsMPGOutputLabel
            // 
            this.carsMPGOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carsMPGOutputLabel.Location = new System.Drawing.Point(200, 124);
            this.carsMPGOutputLabel.Name = "carsMPGOutputLabel";
            this.carsMPGOutputLabel.Size = new System.Drawing.Size(145, 23);
            this.carsMPGOutputLabel.TabIndex = 3;
            this.carsMPGOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(80, 211);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 38);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gallonOfGasUsedTextBox
            // 
            this.gallonOfGasUsedTextBox.Location = new System.Drawing.Point(203, 70);
            this.gallonOfGasUsedTextBox.Name = "gallonOfGasUsedTextBox";
            this.gallonOfGasUsedTextBox.Size = new System.Drawing.Size(142, 20);
            this.gallonOfGasUsedTextBox.TabIndex = 6;
            // 
            // numberOfMilesDrivenTextBox
            // 
            this.numberOfMilesDrivenTextBox.Location = new System.Drawing.Point(203, 34);
            this.numberOfMilesDrivenTextBox.Name = "numberOfMilesDrivenTextBox";
            this.numberOfMilesDrivenTextBox.Size = new System.Drawing.Size(142, 20);
            this.numberOfMilesDrivenTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.numberOfMilesDrivenTextBox);
            this.Controls.Add(this.gallonOfGasUsedTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.carsMPGOutputLabel);
            this.Controls.Add(this.carsMPGLabel);
            this.Controls.Add(this.gllonOfGasUsedLabel);
            this.Controls.Add(this.numberOfMilesDrivenLabel);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfMilesDrivenLabel;
        private System.Windows.Forms.Label gllonOfGasUsedLabel;
        private System.Windows.Forms.Label carsMPGLabel;
        private System.Windows.Forms.Label carsMPGOutputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox gallonOfGasUsedTextBox;
        private System.Windows.Forms.TextBox numberOfMilesDrivenTextBox;
    }
}

