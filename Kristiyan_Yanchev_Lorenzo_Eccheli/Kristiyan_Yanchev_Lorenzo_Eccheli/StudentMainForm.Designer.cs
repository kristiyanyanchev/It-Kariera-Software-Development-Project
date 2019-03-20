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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Name = "exitButton";
            this.toolTip.SetToolTip(this.exitButton, resources.GetString("exitButton.ToolTip"));
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.toolTip.SetToolTip(this.languageComboBox, resources.GetString("languageComboBox.ToolTip"));
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            this.toolTip.SetToolTip(this.languageLabel, resources.GetString("languageLabel.ToolTip"));
            // 
            // introductionLabel
            // 
            resources.ApplyResources(this.introductionLabel, "introductionLabel");
            this.introductionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.introductionLabel.Name = "introductionLabel";
            this.toolTip.SetToolTip(this.introductionLabel, resources.GetString("introductionLabel.ToolTip"));
            // 
            // MenuStrip
            // 
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.BackColor = System.Drawing.Color.FloralWhite;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradesToolStripMenuItem,
            this.absencesToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.changeInformationToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.toolTip.SetToolTip(this.MenuStrip, resources.GetString("MenuStrip.ToolTip"));
            // 
            // gradesToolStripMenuItem
            // 
            resources.ApplyResources(this.gradesToolStripMenuItem, "gradesToolStripMenuItem");
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // absencesToolStripMenuItem
            // 
            resources.ApplyResources(this.absencesToolStripMenuItem, "absencesToolStripMenuItem");
            this.absencesToolStripMenuItem.Name = "absencesToolStripMenuItem";
            this.absencesToolStripMenuItem.Click += new System.EventHandler(this.absencesToolStripMenuItem_Click);
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
            // panelInformation
            // 
            resources.ApplyResources(this.panelInformation, "panelInformation");
            this.panelInformation.BackColor = System.Drawing.Color.FloralWhite;
            this.panelInformation.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.panelInformation.Name = "panelInformation";
            this.toolTip.SetToolTip(this.panelInformation, resources.GetString("panelInformation.ToolTip"));
            // 
            // StudentMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "StudentMainForm";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentMainForm_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInformationToolStripMenuItem;
        private System.Windows.Forms.Panel panelInformation;
    }
}