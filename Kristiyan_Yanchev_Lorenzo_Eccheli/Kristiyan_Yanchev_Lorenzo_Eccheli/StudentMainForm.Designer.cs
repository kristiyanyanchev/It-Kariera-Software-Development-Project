namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentMainForm
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
            this.viewGradesButton = new System.Windows.Forms.Button();
            this.viewAbsencesButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeInformation = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewGradesButton
            // 
            this.viewGradesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewGradesButton.FlatAppearance.BorderSize = 0;
            this.viewGradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewGradesButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.viewGradesButton.Location = new System.Drawing.Point(53, 152);
            this.viewGradesButton.Name = "viewGradesButton";
            this.viewGradesButton.Size = new System.Drawing.Size(130, 60);
            this.viewGradesButton.TabIndex = 0;
            this.viewGradesButton.Text = "Grades";
            this.viewGradesButton.UseVisualStyleBackColor = false;
            this.viewGradesButton.Click += new System.EventHandler(this.viewGradesButton_Click);
            // 
            // viewAbsencesButton
            // 
            this.viewAbsencesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewAbsencesButton.FlatAppearance.BorderSize = 0;
            this.viewAbsencesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAbsencesButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.viewAbsencesButton.Location = new System.Drawing.Point(357, 152);
            this.viewAbsencesButton.Name = "viewAbsencesButton";
            this.viewAbsencesButton.Size = new System.Drawing.Size(130, 60);
            this.viewAbsencesButton.TabIndex = 1;
            this.viewAbsencesButton.Text = "Absence";
            this.viewAbsencesButton.UseVisualStyleBackColor = false;
            this.viewAbsencesButton.Click += new System.EventHandler(this.viewAbsencesButton_Click);
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.Color.FloralWhite;
            this.changePassword.FlatAppearance.BorderSize = 0;
            this.changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassword.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.changePassword.Location = new System.Drawing.Point(357, 231);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(130, 60);
            this.changePassword.TabIndex = 5;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitButton.Location = new System.Drawing.Point(549, 434);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 66);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // changeInformation
            // 
            this.changeInformation.BackColor = System.Drawing.Color.FloralWhite;
            this.changeInformation.FlatAppearance.BorderSize = 0;
            this.changeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeInformation.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.changeInformation.Location = new System.Drawing.Point(357, 307);
            this.changeInformation.Name = "changeInformation";
            this.changeInformation.Size = new System.Drawing.Size(130, 60);
            this.changeInformation.TabIndex = 9;
            this.changeInformation.Text = "Change Information";
            this.changeInformation.UseVisualStyleBackColor = false;
            this.changeInformation.Click += new System.EventHandler(this.changeInformationButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "Bulgarian",
            "English"});
            this.languageComboBox.Location = new System.Drawing.Point(608, 70);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(76, 27);
            this.languageComboBox.TabIndex = 10;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.languageLabel.Location = new System.Drawing.Point(518, 70);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(62, 19);
            this.languageLabel.TabIndex = 11;
            this.languageLabel.Text = "Language";
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.introductionLabel.Font = new System.Drawing.Font("Sitka Heading", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.introductionLabel.Location = new System.Drawing.Point(149, 20);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(273, 28);
            this.introductionLabel.TabIndex = 12;
            this.introductionLabel.Text = "Welcome to E-journal , Student\r\n";
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(705, 512);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.changeInformation);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.viewAbsencesButton);
            this.Controls.Add(this.viewGradesButton);
            this.Name = "StudentMainForm";
            this.Text = "E-journal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewGradesButton;
        private System.Windows.Forms.Button viewAbsencesButton;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeInformation;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label introductionLabel;
    }
}