namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentRegistrationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistrationForm));
            this.introductionLabel = new System.Windows.Forms.Label();
            this.parttwoLabel = new System.Windows.Forms.Label();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.egnLabel = new System.Windows.Forms.Label();
            this.egnTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.studentdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.classLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.dateofbirthLabel.Location = new System.Drawing.Point(103, 105);
            this.dateofbirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(65, 13);
            this.dateofbirthLabel.TabIndex = 17;
            this.dateofbirthLabel.Text = "Date of birth";
            // 
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Location = new System.Drawing.Point(103, 151);
            this.egnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(30, 13);
            this.egnLabel.TabIndex = 19;
            this.egnLabel.Text = "EGN";
            // 
            // egnTextBox
            // 
            this.egnTextBox.Location = new System.Drawing.Point(172, 147);
            this.egnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.Size = new System.Drawing.Size(76, 20);
            this.egnTextBox.TabIndex = 22;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(146, 244);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(56, 41);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // studentdateofbirth
            // 
            this.studentdateofbirth.Location = new System.Drawing.Point(172, 105);
            this.studentdateofbirth.Margin = new System.Windows.Forms.Padding(2);
            this.studentdateofbirth.Name = "studentdateofbirth";
            this.studentdateofbirth.Size = new System.Drawing.Size(151, 20);
            this.studentdateofbirth.TabIndex = 25;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(103, 196);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 26;
            this.classLabel.Text = "Class";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(172, 196);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(76, 20);
            this.classTextBox.TabIndex = 27;
            // 
            // StudentFormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.studentdateofbirth);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.egnTextBox);
            this.Controls.Add(this.egnLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.parttwoLabel);
            this.Controls.Add(this.introductionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DateTimePicker studentdateofbirth;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.ToolTip formToolTip;
    }
}