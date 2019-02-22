namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentFormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFormRegistration));
            this.introductionLabel = new System.Windows.Forms.Label();
            this.parttwoLabel = new System.Windows.Forms.Label();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.egnLabel = new System.Windows.Forms.Label();
            this.egnTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateofbirthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.Location = new System.Drawing.Point(110, 21);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(216, 17);
            this.introductionLabel.TabIndex = 1;
            this.introductionLabel.Text = "Registration  to School E-Journal";
            // 
            // parttwoLabel
            // 
            this.parttwoLabel.AutoSize = true;
            this.parttwoLabel.Location = new System.Drawing.Point(175, 68);
            this.parttwoLabel.Name = "parttwoLabel";
            this.parttwoLabel.Size = new System.Drawing.Size(46, 17);
            this.parttwoLabel.TabIndex = 16;
            this.parttwoLabel.Text = "Part 2";
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Location = new System.Drawing.Point(53, 143);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(86, 17);
            this.dateofbirthLabel.TabIndex = 17;
            this.dateofbirthLabel.Text = "Date of birth";
            // 
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Location = new System.Drawing.Point(53, 202);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(38, 17);
            this.egnLabel.TabIndex = 19;
            this.egnLabel.Text = "EGN";
            // 
            // egnTextBox
            // 
            this.egnTextBox.Location = new System.Drawing.Point(156, 199);
            this.egnTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.Size = new System.Drawing.Size(100, 22);
            this.egnTextBox.TabIndex = 22;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(149, 277);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(107, 52);
            this.registrationButton.TabIndex = 23;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(347, 358);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 50);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateofbirthTextBox
            // 
            this.dateofbirthTextBox.Location = new System.Drawing.Point(156, 143);
            this.dateofbirthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateofbirthTextBox.Name = "dateofbirthTextBox";
            this.dateofbirthTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateofbirthTextBox.TabIndex = 25;
            // 
            // StudentFormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 419);
            this.Controls.Add(this.dateofbirthTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.egnTextBox);
            this.Controls.Add(this.egnLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.parttwoLabel);
            this.Controls.Add(this.introductionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentFormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School E-Journal Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Label parttwoLabel;
        private System.Windows.Forms.Label dateofbirthLabel;
        private System.Windows.Forms.Label egnLabel;
        private System.Windows.Forms.TextBox egnTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox dateofbirthTextBox;
    }
}