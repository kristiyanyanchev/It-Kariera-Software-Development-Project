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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageComboBox
            // 
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Bulgarian"});
            this.languageComboBox.Location = new System.Drawing.Point(441, 78);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageComboBox.TabIndex = 23;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.languageLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.languageLabel.Location = new System.Drawing.Point(347, 78);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(62, 19);
            this.languageLabel.TabIndex = 24;
            this.languageLabel.Text = "Language";
            // 
            // panelInformation
            // 
            this.panelInformation.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.panelInformation.Location = new System.Drawing.Point(327, 151);
            this.panelInformation.Margin = new System.Windows.Forms.Padding(2);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(350, 230);
            this.panelInformation.TabIndex = 25;
            // 
            // teacherListBox
            // 
            this.teacherListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.teacherListBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.ItemHeight = 19;
            this.teacherListBox.Location = new System.Drawing.Point(26, 78);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(209, 232);
            this.teacherListBox.TabIndex = 26;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.selectButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectButton.Location = new System.Drawing.Point(26, 316);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(90, 51);
            this.selectButton.TabIndex = 27;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gradeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gradeButton.Location = new System.Drawing.Point(145, 316);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(90, 51);
            this.gradeButton.TabIndex = 28;
            this.gradeButton.Text = "Grade";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(541, 408);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 56);
            this.exitButton.TabIndex = 29;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FloralWhite;
            this.MenuStrip.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradesToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.changeInformationToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(678, 27);
            this.MenuStrip.TabIndex = 30;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(118, 23);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // changeInformationToolStripMenuItem
            // 
            this.changeInformationToolStripMenuItem.Name = "changeInformationToolStripMenuItem";
            this.changeInformationToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.changeInformationToolStripMenuItem.Text = "Change Information";
            this.changeInformationToolStripMenuItem.Click += new System.EventHandler(this.changeInformationToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(678, 476);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentForm";
            this.Text = "Parent Classbook";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInformationToolStripMenuItem;
    }
}