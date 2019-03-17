namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.introductionLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.visibleCheckBox = new System.Windows.Forms.CheckBox();
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.validationCodeLabel = new System.Windows.Forms.Label();
            this.validationCodeTextBox = new System.Windows.Forms.TextBox();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.ucnTextBox = new System.Windows.Forms.TextBox();
            this.classnameTextBox = new System.Windows.Forms.TextBox();
            this.nameofchildTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.possitionTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.ucnLabel = new System.Windows.Forms.Label();
            this.classnameLabel = new System.Windows.Forms.Label();
            this.nameofchildLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.possitionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introductionLabel
            // 
            resources.ApplyResources(this.introductionLabel, "introductionLabel");
            this.introductionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.introductionLabel.Name = "introductionLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // phoneLabel
            // 
            resources.ApplyResources(this.phoneLabel, "phoneLabel");
            this.phoneLabel.Name = "phoneLabel";
            // 
            // roleLabel
            // 
            resources.ApplyResources(this.roleLabel, "roleLabel");
            this.roleLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.roleLabel.Name = "roleLabel";
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            resources.GetString("roleComboBox.Items"),
            resources.GetString("roleComboBox.Items1"),
            resources.GetString("roleComboBox.Items2"),
            resources.GetString("roleComboBox.Items3")});
            resources.ApplyResources(this.roleComboBox, "roleComboBox");
            this.roleComboBox.Name = "roleComboBox";
            this.formToolTip.SetToolTip(this.roleComboBox, resources.GetString("roleComboBox.ToolTip"));
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.formToolTip.SetToolTip(this.firstNameTextBox, resources.GetString("firstNameTextBox.ToolTip"));
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.formToolTip.SetToolTip(this.passwordTextBox, resources.GetString("passwordTextBox.ToolTip"));
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            this.formToolTip.SetToolTip(this.emailTextBox, resources.GetString("emailTextBox.ToolTip"));
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            this.formToolTip.SetToolTip(this.addressTextBox, resources.GetString("addressTextBox.ToolTip"));
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.formToolTip.SetToolTip(this.phoneNumberTextBox, resources.GetString("phoneNumberTextBox.ToolTip"));
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FloralWhite;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.registrationButton, "registrationButton");
            this.registrationButton.Name = "registrationButton";
            this.formToolTip.SetToolTip(this.registrationButton, resources.GetString("registrationButton.ToolTip"));
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.formToolTip.SetToolTip(this.exitButton, resources.GetString("exitButton.ToolTip"));
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.formToolTip.SetToolTip(this.lastNameTextBox, resources.GetString("lastNameTextBox.ToolTip"));
            // 
            // visibleCheckBox
            // 
            resources.ApplyResources(this.visibleCheckBox, "visibleCheckBox");
            this.visibleCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.visibleCheckBox.Name = "visibleCheckBox";
            this.formToolTip.SetToolTip(this.visibleCheckBox, resources.GetString("visibleCheckBox.ToolTip"));
            this.visibleCheckBox.UseVisualStyleBackColor = false;
            this.visibleCheckBox.CheckedChanged += new System.EventHandler(this.visibleCheckBox_CheckedChanged);
            // 
            // validationCodeLabel
            // 
            resources.ApplyResources(this.validationCodeLabel, "validationCodeLabel");
            this.validationCodeLabel.Name = "validationCodeLabel";
            this.formToolTip.SetToolTip(this.validationCodeLabel, resources.GetString("validationCodeLabel.ToolTip"));
            // 
            // validationCodeTextBox
            // 
            this.validationCodeTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.validationCodeTextBox, "validationCodeTextBox");
            this.validationCodeTextBox.Name = "validationCodeTextBox";
            this.formToolTip.SetToolTip(this.validationCodeTextBox, resources.GetString("validationCodeTextBox.ToolTip"));
            // 
            // birthdatePicker
            // 
            resources.ApplyResources(this.birthdatePicker, "birthdatePicker");
            this.birthdatePicker.Name = "birthdatePicker";
            this.formToolTip.SetToolTip(this.birthdatePicker, resources.GetString("birthdatePicker.ToolTip"));
            // 
            // ucnTextBox
            // 
            this.ucnTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.ucnTextBox, "ucnTextBox");
            this.ucnTextBox.Name = "ucnTextBox";
            this.formToolTip.SetToolTip(this.ucnTextBox, resources.GetString("ucnTextBox.ToolTip"));
            // 
            // classnameTextBox
            // 
            this.classnameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.classnameTextBox, "classnameTextBox");
            this.classnameTextBox.Name = "classnameTextBox";
            this.formToolTip.SetToolTip(this.classnameTextBox, resources.GetString("classnameTextBox.ToolTip"));
            // 
            // nameofchildTextBox
            // 
            this.nameofchildTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.nameofchildTextBox, "nameofchildTextBox");
            this.nameofchildTextBox.Name = "nameofchildTextBox";
            this.formToolTip.SetToolTip(this.nameofchildTextBox, resources.GetString("nameofchildTextBox.ToolTip"));
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            this.formToolTip.SetToolTip(this.nameTextBox, resources.GetString("nameTextBox.ToolTip"));
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FloralWhite;
            this.backButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.formToolTip.SetToolTip(this.backButton, resources.GetString("backButton.ToolTip"));
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.formToolTip.SetToolTip(this.languageComboBox, resources.GetString("languageComboBox.ToolTip"));
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.subjectTextBox, "subjectTextBox");
            this.subjectTextBox.Name = "subjectTextBox";
            this.formToolTip.SetToolTip(this.subjectTextBox, resources.GetString("subjectTextBox.ToolTip"));
            // 
            // possitionTextBox
            // 
            this.possitionTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.possitionTextBox, "possitionTextBox");
            this.possitionTextBox.Name = "possitionTextBox";
            this.formToolTip.SetToolTip(this.possitionTextBox, resources.GetString("possitionTextBox.ToolTip"));
            // 
            // birthdayLabel
            // 
            resources.ApplyResources(this.birthdayLabel, "birthdayLabel");
            this.birthdayLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.birthdayLabel.Name = "birthdayLabel";
            // 
            // ucnLabel
            // 
            resources.ApplyResources(this.ucnLabel, "ucnLabel");
            this.ucnLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.ucnLabel.Name = "ucnLabel";
            // 
            // classnameLabel
            // 
            resources.ApplyResources(this.classnameLabel, "classnameLabel");
            this.classnameLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.classnameLabel.Name = "classnameLabel";
            // 
            // nameofchildLabel
            // 
            resources.ApplyResources(this.nameofchildLabel, "nameofchildLabel");
            this.nameofchildLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.nameofchildLabel.Name = "nameofchildLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            // 
            // subjectLabel
            // 
            resources.ApplyResources(this.subjectLabel, "subjectLabel");
            this.subjectLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.subjectLabel.Name = "subjectLabel";
            // 
            // possitionLabel
            // 
            resources.ApplyResources(this.possitionLabel, "possitionLabel");
            this.possitionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.possitionLabel.Name = "possitionLabel";
            // 
            // RegistrationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.possitionTextBox);
            this.Controls.Add(this.possitionLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameofchildTextBox);
            this.Controls.Add(this.nameofchildLabel);
            this.Controls.Add(this.classnameTextBox);
            this.Controls.Add(this.classnameLabel);
            this.Controls.Add(this.ucnLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.ucnTextBox);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.validationCodeTextBox);
            this.Controls.Add(this.validationCodeLabel);
            this.Controls.Add(this.visibleCheckBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.introductionLabel);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCLosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox visibleCheckBox;
        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.Label validationCodeLabel;
        private System.Windows.Forms.TextBox validationCodeTextBox;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.TextBox ucnTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label ucnLabel;
        private System.Windows.Forms.Label classnameLabel;
        private System.Windows.Forms.TextBox classnameTextBox;
        private System.Windows.Forms.Label nameofchildLabel;
        private System.Windows.Forms.TextBox nameofchildTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label possitionLabel;
        private System.Windows.Forms.TextBox possitionTextBox;
    }
}