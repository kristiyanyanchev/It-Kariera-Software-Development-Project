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
            this.schoolLabel = new System.Windows.Forms.Label();
            this.egnLabel = new System.Windows.Forms.Label();
            this.dateofbirthTextBox = new System.Windows.Forms.TextBox();
            this.schoolTextBox = new System.Windows.Forms.TextBox();
            this.egnTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.Location = new System.Drawing.Point(115, 36);
            this.introductionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(161, 13);
            this.introductionLabel.TabIndex = 1;
            this.introductionLabel.Text = "Registration  to School E-Journal";
            // 
            // parttwoLabel
            // 
            this.parttwoLabel.AutoSize = true;
            this.parttwoLabel.Location = new System.Drawing.Point(177, 70);
            this.parttwoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.parttwoLabel.Name = "parttwoLabel";
            this.parttwoLabel.Size = new System.Drawing.Size(35, 13);
            this.parttwoLabel.TabIndex = 16;
            this.parttwoLabel.Text = "Part 2";
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Location = new System.Drawing.Point(62, 105);
            this.dateofbirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(65, 13);
            this.dateofbirthLabel.TabIndex = 17;
            this.dateofbirthLabel.Text = "Date of birth";
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.Location = new System.Drawing.Point(62, 145);
            this.schoolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(40, 13);
            this.schoolLabel.TabIndex = 18;
            this.schoolLabel.Text = "School";
            // 
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Location = new System.Drawing.Point(62, 185);
            this.egnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(30, 13);
            this.egnLabel.TabIndex = 19;
            this.egnLabel.Text = "EGN";
            // 
            // dateofbirthTextBox
            // 
            this.dateofbirthTextBox.Location = new System.Drawing.Point(136, 102);
            this.dateofbirthTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateofbirthTextBox.Name = "dateofbirthTextBox";
            this.dateofbirthTextBox.Size = new System.Drawing.Size(76, 20);
            this.dateofbirthTextBox.TabIndex = 20;
            // 
            // schoolTextBox
            // 
            this.schoolTextBox.Location = new System.Drawing.Point(136, 145);
            this.schoolTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schoolTextBox.Name = "schoolTextBox";
            this.schoolTextBox.Size = new System.Drawing.Size(76, 20);
            this.schoolTextBox.TabIndex = 21;
            // 
            // egnTextBox
            // 
            this.egnTextBox.Location = new System.Drawing.Point(136, 185);
            this.egnTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.Size = new System.Drawing.Size(76, 20);
            this.egnTextBox.TabIndex = 22;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(164, 240);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(80, 42);
            this.registrationButton.TabIndex = 23;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(344, 306);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(56, 41);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // StudentFormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.egnTextBox);
            this.Controls.Add(this.schoolTextBox);
            this.Controls.Add(this.dateofbirthTextBox);
            this.Controls.Add(this.egnLabel);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.parttwoLabel);
            this.Controls.Add(this.introductionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Label egnLabel;
        private System.Windows.Forms.TextBox dateofbirthTextBox;
        private System.Windows.Forms.TextBox schoolTextBox;
        private System.Windows.Forms.TextBox egnTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button exitButton;
    }
}