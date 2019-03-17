namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.visibleCheckBox = new System.Windows.Forms.CheckBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // oldPasswordLabel
            // 
            resources.ApplyResources(this.oldPasswordLabel, "oldPasswordLabel");
            this.oldPasswordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.toolTip.SetToolTip(this.oldPasswordLabel, resources.GetString("oldPasswordLabel.ToolTip"));
            // 
            // newPasswordLabel
            // 
            resources.ApplyResources(this.newPasswordLabel, "newPasswordLabel");
            this.newPasswordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.toolTip.SetToolTip(this.newPasswordLabel, resources.GetString("newPasswordLabel.ToolTip"));
            // 
            // ConfirmPasswordLabel
            // 
            resources.ApplyResources(this.ConfirmPasswordLabel, "ConfirmPasswordLabel");
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.toolTip.SetToolTip(this.ConfirmPasswordLabel, resources.GetString("ConfirmPasswordLabel.ToolTip"));
            // 
            // oldPasswordTextBox
            // 
            resources.ApplyResources(this.oldPasswordTextBox, "oldPasswordTextBox");
            this.oldPasswordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.toolTip.SetToolTip(this.oldPasswordTextBox, resources.GetString("oldPasswordTextBox.ToolTip"));
            // 
            // newPasswordTextBox
            // 
            resources.ApplyResources(this.newPasswordTextBox, "newPasswordTextBox");
            this.newPasswordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.toolTip.SetToolTip(this.newPasswordTextBox, resources.GetString("newPasswordTextBox.ToolTip"));
            // 
            // confirmNewPasswordTextBox
            // 
            resources.ApplyResources(this.confirmNewPasswordTextBox, "confirmNewPasswordTextBox");
            this.confirmNewPasswordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.toolTip.SetToolTip(this.confirmNewPasswordTextBox, resources.GetString("confirmNewPasswordTextBox.ToolTip"));
            // 
            // changePasswordButton
            // 
            resources.ApplyResources(this.changePasswordButton, "changePasswordButton");
            this.changePasswordButton.BackColor = System.Drawing.Color.FloralWhite;
            this.changePasswordButton.Name = "changePasswordButton";
            this.toolTip.SetToolTip(this.changePasswordButton, resources.GetString("changePasswordButton.ToolTip"));
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Name = "closeButton";
            this.toolTip.SetToolTip(this.closeButton, resources.GetString("closeButton.ToolTip"));
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // visibleCheckBox
            // 
            resources.ApplyResources(this.visibleCheckBox, "visibleCheckBox");
            this.visibleCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.visibleCheckBox.Name = "visibleCheckBox";
            this.toolTip.SetToolTip(this.visibleCheckBox, resources.GetString("visibleCheckBox.ToolTip"));
            this.visibleCheckBox.UseVisualStyleBackColor = false;
            this.visibleCheckBox.CheckedChanged += new System.EventHandler(this.visibleCheckBox_CheckedChanged);
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
            // ChangePasswordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.visibleCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Name = "ChangePasswordForm";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox visibleCheckBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}