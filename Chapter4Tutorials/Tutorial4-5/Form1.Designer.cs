namespace Tutorial4_5
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.YellowRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.backtoNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.backtoNormalRadioButton);
            this.colorGroupBox.Controls.Add(this.whiteRadioButton);
            this.colorGroupBox.Controls.Add(this.RedRadioButton);
            this.colorGroupBox.Controls.Add(this.YellowRadioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(351, 205);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Select a Background color";
            // 
            // YellowRadioButton
            // 
            this.YellowRadioButton.AutoSize = true;
            this.YellowRadioButton.Location = new System.Drawing.Point(95, 38);
            this.YellowRadioButton.Name = "YellowRadioButton";
            this.YellowRadioButton.Size = new System.Drawing.Size(56, 17);
            this.YellowRadioButton.TabIndex = 0;
            this.YellowRadioButton.Text = "Yellow";
            this.YellowRadioButton.UseVisualStyleBackColor = true;
            this.YellowRadioButton.CheckedChanged += new System.EventHandler(this.YellowRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(95, 77);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRadioButton.TabIndex = 1;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(95, 118);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 2;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
            // 
            // backtoNormalRadioButton
            // 
            this.backtoNormalRadioButton.AutoSize = true;
            this.backtoNormalRadioButton.Checked = true;
            this.backtoNormalRadioButton.Location = new System.Drawing.Point(95, 159);
            this.backtoNormalRadioButton.Name = "backtoNormalRadioButton";
            this.backtoNormalRadioButton.Size = new System.Drawing.Size(98, 17);
            this.backtoNormalRadioButton.TabIndex = 3;
            this.backtoNormalRadioButton.TabStop = true;
            this.backtoNormalRadioButton.Text = "Back to Normal";
            this.backtoNormalRadioButton.UseVisualStyleBackColor = true;
            this.backtoNormalRadioButton.CheckedChanged += new System.EventHandler(this.backtoNormalRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(129, 238);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorGroupBox);
            this.Name = "Form1";
            this.Text = "Color Theme";
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton backtoNormalRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton YellowRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}

