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
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.visibleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Location = new System.Drawing.Point(12, 25);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(72, 13);
            this.oldPasswordLabel.TabIndex = 0;
            this.oldPasswordLabel.Text = "Old Password";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(12, 56);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.newPasswordLabel.TabIndex = 1;
            this.newPasswordLabel.Text = "New Password";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(12, 83);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPasswordLabel.TabIndex = 2;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(109, 22);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldPasswordTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(109, 49);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(109, 75);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.PasswordChar = '*';
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmNewPasswordTextBox.TabIndex = 5;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(87, 112);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(90, 40);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(214, 161);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 40);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // visibleCheckBox
            // 
            this.visibleCheckBox.AutoSize = true;
            this.visibleCheckBox.Location = new System.Drawing.Point(231, 49);
            this.visibleCheckBox.Name = "visibleCheckBox";
            this.visibleCheckBox.Size = new System.Drawing.Size(56, 17);
            this.visibleCheckBox.TabIndex = 9;
            this.visibleCheckBox.Text = "Visible";
            this.visibleCheckBox.UseVisualStyleBackColor = true;
            this.visibleCheckBox.CheckedChanged += new System.EventHandler(this.visibleCheckBox_CheckedChanged);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 213);
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
            this.Text = "Change password";
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
    }
}