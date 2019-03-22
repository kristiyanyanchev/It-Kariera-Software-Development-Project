namespace WinFormsView.UpdateControls
{
    partial class ChangePasswordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordControl));
            this.visibleCheckBox = new System.Windows.Forms.CheckBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visibleCheckBox
            // 
            resources.ApplyResources(this.visibleCheckBox, "visibleCheckBox");
            this.visibleCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.visibleCheckBox.Name = "visibleCheckBox";
            this.visibleCheckBox.UseVisualStyleBackColor = false;
            this.visibleCheckBox.CheckedChanged += new System.EventHandler(this.visibleCheckBox_CheckedChanged);
            // 
            // changePasswordButton
            // 
            resources.ApplyResources(this.changePasswordButton, "changePasswordButton");
            this.changePasswordButton.BackColor = System.Drawing.Color.FloralWhite;
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // confirmNewPasswordTextBox
            // 
            resources.ApplyResources(this.confirmNewPasswordTextBox, "confirmNewPasswordTextBox");
            this.confirmNewPasswordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            // 
            // newPasswordTextBox
            // 
            resources.ApplyResources(this.newPasswordTextBox, "newPasswordTextBox");
            this.newPasswordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            // 
            // oldPasswordTextBox
            // 
            resources.ApplyResources(this.oldPasswordTextBox, "oldPasswordTextBox");
            this.oldPasswordTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            // 
            // ConfirmPasswordLabel
            // 
            resources.ApplyResources(this.ConfirmPasswordLabel, "ConfirmPasswordLabel");
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            // 
            // newPasswordLabel
            // 
            resources.ApplyResources(this.newPasswordLabel, "newPasswordLabel");
            this.newPasswordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.newPasswordLabel.Name = "newPasswordLabel";
            // 
            // oldPasswordLabel
            // 
            resources.ApplyResources(this.oldPasswordLabel, "oldPasswordLabel");
            this.oldPasswordLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            // 
            // ChangePasswordControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.visibleCheckBox);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Name = "ChangePasswordControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox visibleCheckBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
    }
}
