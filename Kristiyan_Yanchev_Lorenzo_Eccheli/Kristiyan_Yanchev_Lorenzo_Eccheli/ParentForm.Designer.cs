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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phonenumberLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.Name = "exitButton";
            this.toolTip.SetToolTip(this.exitButton, resources.GetString("exitButton.ToolTip"));
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // teacherListBox
            // 
            resources.ApplyResources(this.teacherListBox, "teacherListBox");
            this.teacherListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.Name = "teacherListBox";
            this.toolTip.SetToolTip(this.teacherListBox, resources.GetString("teacherListBox.ToolTip"));
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.emailTextBox, resources.GetString("emailTextBox.ToolTip"));
            // 
            // phoneNumberTextBox
            // 
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.toolTip.SetToolTip(this.phoneNumberTextBox, resources.GetString("phoneNumberTextBox.ToolTip"));
            // 
            // selectButton
            // 
            resources.ApplyResources(this.selectButton, "selectButton");
            this.selectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.selectButton.Name = "selectButton";
            this.toolTip.SetToolTip(this.selectButton, resources.GetString("selectButton.ToolTip"));
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // gradeButton
            // 
            resources.ApplyResources(this.gradeButton, "gradeButton");
            this.gradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeButton.Name = "gradeButton";
            this.toolTip.SetToolTip(this.gradeButton, resources.GetString("gradeButton.ToolTip"));
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.emailLabel.Name = "emailLabel";
            this.toolTip.SetToolTip(this.emailLabel, resources.GetString("emailLabel.ToolTip"));
            // 
            // phonenumberLabel
            // 
            resources.ApplyResources(this.phonenumberLabel, "phonenumberLabel");
            this.phonenumberLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.phonenumberLabel.Name = "phonenumberLabel";
            this.toolTip.SetToolTip(this.phonenumberLabel, resources.GetString("phonenumberLabel.ToolTip"));
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            this.toolTip.SetToolTip(this.languageLabel, resources.GetString("languageLabel.ToolTip"));
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
            // ParentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.phonenumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.exitButton);
            this.Name = "ParentForm";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phonenumberLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}