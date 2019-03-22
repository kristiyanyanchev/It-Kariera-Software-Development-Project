namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.visiblepasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            this.formToolTip.SetToolTip(this.usernameTextBox, resources.GetString("usernameTextBox.ToolTip"));
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.OldLace;
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.formToolTip.SetToolTip(this.passwordTextBox, resources.GetString("passwordTextBox.ToolTip"));
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // introductionLabel
            // 
            resources.ApplyResources(this.introductionLabel, "introductionLabel");
            this.introductionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.introductionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.introductionLabel.Name = "introductionLabel";
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.logInBtn, "logInBtn");
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.Name = "logInBtn";
            this.formToolTip.SetToolTip(this.logInBtn, resources.GetString("logInBtn.ToolTip"));
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.registerBtn, "registerBtn");
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.Name = "registerBtn";
            this.formToolTip.SetToolTip(this.registerBtn, resources.GetString("registerBtn.ToolTip"));
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitBtn.Name = "exitBtn";
            this.formToolTip.SetToolTip(this.exitBtn, resources.GetString("exitBtn.ToolTip"));
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // visiblepasswordCheckBox
            // 
            resources.ApplyResources(this.visiblepasswordCheckBox, "visiblepasswordCheckBox");
            this.visiblepasswordCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.visiblepasswordCheckBox.Name = "visiblepasswordCheckBox";
            this.formToolTip.SetToolTip(this.visiblepasswordCheckBox, resources.GetString("visiblepasswordCheckBox.ToolTip"));
            this.visiblepasswordCheckBox.UseVisualStyleBackColor = false;
            this.visiblepasswordCheckBox.CheckedChanged += new System.EventHandler(this.visiblepasswordCheckBox_CheckedChanged);
            // 
            // languageComboBox
            // 
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            this.languageComboBox.Name = "languageComboBox";
            this.formToolTip.SetToolTip(this.languageComboBox, resources.GetString("languageComboBox.ToolTip"));
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            // 
            // LogInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.visiblepasswordCheckBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.E_Journal_FormClosing);
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox visiblepasswordCheckBox;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ToolTip formToolTip;
    }
}

