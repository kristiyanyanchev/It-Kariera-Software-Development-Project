﻿namespace Kristiyan_Yanchev_Lorenzo_Eccheli.UpdateControls
{
    partial class ChangeInformationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInformationControl));
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            resources.ApplyResources(this.saveChangesButton, "saveChangesButton");
            this.saveChangesButton.BackColor = System.Drawing.Color.FloralWhite;
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.emailTextBox.Name = "emailTextBox";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.emailLabel.Name = "emailLabel";
            // 
            // PhoneNumberTextBox
            // 
            resources.ApplyResources(this.PhoneNumberTextBox, "PhoneNumberTextBox");
            this.PhoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
            this.phoneNumberLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // ChangeInformationControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Name = "ChangeInformationControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
    }
}