namespace WinFormsView.UpdateControls
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.changeInfrormationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.emailLabel.Name = "emailLabel";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
            this.phoneNumberLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            // 
            // changeInfrormationButton
            // 
            this.changeInfrormationButton.BackColor = System.Drawing.Color.FloralWhite;
            this.changeInfrormationButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.changeInfrormationButton, "changeInfrormationButton");
            this.changeInfrormationButton.Name = "changeInfrormationButton";
            this.changeInfrormationButton.UseVisualStyleBackColor = false;
            this.changeInfrormationButton.Click += new System.EventHandler(this.changeInfrormationButton_Click);
            // 
            // ChangeInformationControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.changeInfrormationButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "ChangeInformationControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button changeInfrormationButton;
    }
}
