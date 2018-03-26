namespace Chapter4Tutorials
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
            this.enterThreeTestScoresLabel = new System.Windows.Forms.Label();
            this.TestScore1Label = new System.Windows.Forms.Label();
            this.testScore2label = new System.Windows.Forms.Label();
            this.testScore3Label = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.averageOutputlabel = new System.Windows.Forms.Label();
            this.testScore1textBox = new System.Windows.Forms.TextBox();
            this.testScore2TextBox = new System.Windows.Forms.TextBox();
            this.testScore3TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterThreeTestScoresLabel
            // 
            this.enterThreeTestScoresLabel.AutoSize = true;
            this.enterThreeTestScoresLabel.Location = new System.Drawing.Point(32, 20);
            this.enterThreeTestScoresLabel.Name = "enterThreeTestScoresLabel";
            this.enterThreeTestScoresLabel.Size = new System.Drawing.Size(119, 13);
            this.enterThreeTestScoresLabel.TabIndex = 0;
            this.enterThreeTestScoresLabel.Text = "Enter Three test Scores";
            // 
            // TestScore1Label
            // 
            this.TestScore1Label.AutoSize = true;
            this.TestScore1Label.Location = new System.Drawing.Point(62, 56);
            this.TestScore1Label.Name = "TestScore1Label";
            this.TestScore1Label.Size = new System.Drawing.Size(75, 13);
            this.TestScore1Label.TabIndex = 1;
            this.TestScore1Label.Text = "Test Score #1";
            // 
            // testScore2label
            // 
            this.testScore2label.AutoSize = true;
            this.testScore2label.Location = new System.Drawing.Point(62, 86);
            this.testScore2label.Name = "testScore2label";
            this.testScore2label.Size = new System.Drawing.Size(75, 13);
            this.testScore2label.TabIndex = 2;
            this.testScore2label.Text = "Test Score #2";
            // 
            // testScore3Label
            // 
            this.testScore3Label.AutoSize = true;
            this.testScore3Label.Location = new System.Drawing.Point(62, 115);
            this.testScore3Label.Name = "testScore3Label";
            this.testScore3Label.Size = new System.Drawing.Size(75, 13);
            this.testScore3Label.TabIndex = 3;
            this.testScore3Label.Text = "Test Score #3";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(90, 159);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(47, 13);
            this.AverageLabel.TabIndex = 4;
            this.AverageLabel.Text = "Average";
            // 
            // averageOutputlabel
            // 
            this.averageOutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageOutputlabel.Location = new System.Drawing.Point(153, 149);
            this.averageOutputlabel.Name = "averageOutputlabel";
            this.averageOutputlabel.Size = new System.Drawing.Size(149, 23);
            this.averageOutputlabel.TabIndex = 5;
            this.averageOutputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testScore1textBox
            // 
            this.testScore1textBox.Location = new System.Drawing.Point(153, 49);
            this.testScore1textBox.Name = "testScore1textBox";
            this.testScore1textBox.Size = new System.Drawing.Size(149, 20);
            this.testScore1textBox.TabIndex = 6;
            // 
            // testScore2TextBox
            // 
            this.testScore2TextBox.Location = new System.Drawing.Point(153, 82);
            this.testScore2TextBox.Name = "testScore2TextBox";
            this.testScore2TextBox.Size = new System.Drawing.Size(149, 20);
            this.testScore2TextBox.TabIndex = 7;
            // 
            // testScore3TextBox
            // 
            this.testScore3TextBox.Location = new System.Drawing.Point(153, 108);
            this.testScore3TextBox.Name = "testScore3TextBox";
            this.testScore3TextBox.Size = new System.Drawing.Size(149, 20);
            this.testScore3TextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(23, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(114, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(172, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(283, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScore3TextBox);
            this.Controls.Add(this.testScore2TextBox);
            this.Controls.Add(this.testScore1textBox);
            this.Controls.Add(this.averageOutputlabel);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.testScore3Label);
            this.Controls.Add(this.testScore2label);
            this.Controls.Add(this.TestScore1Label);
            this.Controls.Add(this.enterThreeTestScoresLabel);
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterThreeTestScoresLabel;
        private System.Windows.Forms.Label TestScore1Label;
        private System.Windows.Forms.Label testScore2label;
        private System.Windows.Forms.Label testScore3Label;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label averageOutputlabel;
        private System.Windows.Forms.TextBox testScore1textBox;
        private System.Windows.Forms.TextBox testScore2TextBox;
        private System.Windows.Forms.TextBox testScore3TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

