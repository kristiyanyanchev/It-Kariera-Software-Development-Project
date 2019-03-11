namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class ParentForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phonenumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.Location = new System.Drawing.Point(442, 372);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 66);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // teacherListBox
            // 
            this.teacherListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.teacherListBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.ItemHeight = 19;
            this.teacherListBox.Location = new System.Drawing.Point(35, 52);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(209, 251);
            this.teacherListBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.emailTextBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.emailTextBox.Location = new System.Drawing.Point(425, 104);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(131, 24);
            this.emailTextBox.TabIndex = 15;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(425, 167);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(131, 24);
            this.phoneNumberTextBox.TabIndex = 16;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.selectButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selectButton.Location = new System.Drawing.Point(35, 344);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(90, 51);
            this.selectButton.TabIndex = 17;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gradeButton.Location = new System.Drawing.Point(154, 344);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(90, 51);
            this.gradeButton.TabIndex = 18;
            this.gradeButton.Text = "Grade";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.emailLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.emailLabel.Location = new System.Drawing.Point(331, 107);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(40, 19);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email";
            // 
            // phonenumberLabel
            // 
            this.phonenumberLabel.AutoSize = true;
            this.phonenumberLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.phonenumberLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.phonenumberLabel.Location = new System.Drawing.Point(331, 170);
            this.phonenumberLabel.Name = "phonenumberLabel";
            this.phonenumberLabel.Size = new System.Drawing.Size(88, 19);
            this.phonenumberLabel.TabIndex = 20;
            this.phonenumberLabel.Text = "Phone number";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.phonenumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.closeButton);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phonenumberLabel;
    }
}