namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class ChangeInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInformationForm));
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
            this.phoneNumberLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.PhoneNumberTextBox, "PhoneNumberTextBox");
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.emailLabel.Name = "emailLabel";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.saveChangesButton, "saveChangesButton");
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // ChangeInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Name = "ChangeInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}