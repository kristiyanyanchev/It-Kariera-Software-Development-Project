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
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            // 
            // panelInformation
            // 
            resources.ApplyResources(this.panelInformation, "panelInformation");
            this.panelInformation.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.panelInformation.Name = "panelInformation";
            // 
            // teacherListBox
            // 
            resources.ApplyResources(this.teacherListBox, "teacherListBox");
            this.teacherListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.Name = "teacherListBox";
            // 
            // selectButton
            // 
            resources.ApplyResources(this.selectButton, "selectButton");
            this.selectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.selectButton.Name = "selectButton";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // gradeButton
            // 
            resources.ApplyResources(this.gradeButton, "gradeButton");
            this.gradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MenuStrip
            // 
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.BackColor = System.Drawing.Color.FloralWhite;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradesToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.changeInformationToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            // 
            // gradesToolStripMenuItem
            // 
            resources.ApplyResources(this.gradesToolStripMenuItem, "gradesToolStripMenuItem");
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // changeInformationToolStripMenuItem
            // 
            resources.ApplyResources(this.changeInformationToolStripMenuItem, "changeInformationToolStripMenuItem");
            this.changeInformationToolStripMenuItem.Name = "changeInformationToolStripMenuItem";
            this.changeInformationToolStripMenuItem.Click += new System.EventHandler(this.changeInformationToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Name = "ParentForm";
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