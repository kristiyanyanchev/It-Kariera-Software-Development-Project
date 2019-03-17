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
            this.viewGradesButton = new System.Windows.Forms.Button();
            this.viewAbsencesButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeInformation = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // viewGradesButton
            // 
            resources.ApplyResources(this.viewGradesButton, "viewGradesButton");
            this.viewGradesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewGradesButton.FlatAppearance.BorderSize = 0;
            this.viewGradesButton.Name = "viewGradesButton";
            this.toolTip.SetToolTip(this.viewGradesButton, resources.GetString("viewGradesButton.ToolTip"));
            this.viewGradesButton.UseVisualStyleBackColor = false;
            this.viewGradesButton.Click += new System.EventHandler(this.viewGradesButton_Click);
            // 
            // viewAbsencesButton
            // 
            resources.ApplyResources(this.viewAbsencesButton, "viewAbsencesButton");
            this.viewAbsencesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewAbsencesButton.FlatAppearance.BorderSize = 0;
            this.viewAbsencesButton.Name = "viewAbsencesButton";
            this.toolTip.SetToolTip(this.viewAbsencesButton, resources.GetString("viewAbsencesButton.ToolTip"));
            this.viewAbsencesButton.UseVisualStyleBackColor = false;
            this.viewAbsencesButton.Click += new System.EventHandler(this.viewAbsencesButton_Click);
            // 
            // changePassword
            // 
            resources.ApplyResources(this.changePassword, "changePassword");
            this.changePassword.BackColor = System.Drawing.Color.FloralWhite;
            this.changePassword.FlatAppearance.BorderSize = 0;
            this.changePassword.Name = "changePassword";
            this.toolTip.SetToolTip(this.changePassword, resources.GetString("changePassword.ToolTip"));
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
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
            // changeInformation
            // 
            resources.ApplyResources(this.changeInformation, "changeInformation");
            this.changeInformation.BackColor = System.Drawing.Color.FloralWhite;
            this.changeInformation.FlatAppearance.BorderSize = 0;
            this.changeInformation.Name = "changeInformation";
            this.toolTip.SetToolTip(this.changeInformation, resources.GetString("changeInformation.ToolTip"));
            this.changeInformation.UseVisualStyleBackColor = false;
            this.changeInformation.Click += new System.EventHandler(this.changeInformationButton_Click);
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
            // StudentMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.changeInformation);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.viewAbsencesButton);
            this.Controls.Add(this.viewGradesButton);
            this.Name = "StudentMainForm";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private System.Windows.Forms.ToolTip toolTip;
    }
}