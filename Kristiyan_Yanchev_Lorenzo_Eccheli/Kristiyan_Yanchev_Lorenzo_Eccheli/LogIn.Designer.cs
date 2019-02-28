namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class E_Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Journal));
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
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 62);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 118);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.Location = new System.Drawing.Point(96, 62);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 2;
            this.formToolTip.SetToolTip(this.usernameTextBox, "Enter your first name.");
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 115);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            this.formToolTip.SetToolTip(this.passwordTextBox, "Enter your account password.");
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.introductionLabel.Location = new System.Drawing.Point(82, 9);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(165, 15);
            this.introductionLabel.TabIndex = 4;
            this.introductionLabel.Text = "Welcome to the school E-Journal";
            // 
            // logInBtn
            // 
            this.logInBtn.Enabled = false;
            this.logInBtn.Location = new System.Drawing.Point(181, 183);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(107, 46);
            this.logInBtn.TabIndex = 5;
            this.logInBtn.Text = "Log in";
            this.formToolTip.SetToolTip(this.logInBtn, "Log in into an existing account.");
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(29, 183);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(107, 46);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Register";
            this.formToolTip.SetToolTip(this.registerBtn, "Make new E-journal account");
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(329, 235);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 46);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.formToolTip.SetToolTip(this.exitBtn, "Exit the application.");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // visiblepasswordCheckBox
            // 
            this.visiblepasswordCheckBox.AutoSize = true;
            this.visiblepasswordCheckBox.Location = new System.Drawing.Point(249, 117);
            this.visiblepasswordCheckBox.Name = "visiblepasswordCheckBox";
            this.visiblepasswordCheckBox.Size = new System.Drawing.Size(56, 17);
            this.visiblepasswordCheckBox.TabIndex = 8;
            this.visiblepasswordCheckBox.Text = "Visible";
            this.formToolTip.SetToolTip(this.visiblepasswordCheckBox, "Make your password visible or unvisible");
            this.visiblepasswordCheckBox.UseVisualStyleBackColor = true;
            this.visiblepasswordCheckBox.CheckedChanged += new System.EventHandler(this.visiblepasswordCheckBox_CheckedChanged);
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Bulgarian"});
            this.languageComboBox.Location = new System.Drawing.Point(350, 32);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(87, 21);
            this.languageComboBox.TabIndex = 9;
            this.languageComboBox.Text = "English";
            this.formToolTip.SetToolTip(this.languageComboBox, "Change your language.");
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(272, 35);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(51, 13);
            this.languageLabel.TabIndex = 10;
            this.languageLabel.Text = "language";
            // 
            // E_Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(445, 295);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(98, 97);
            this.Name = "E_Journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School E-journal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.E_Journal_FormClosing);
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

