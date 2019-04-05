namespace WinFormsView.ParentControls
{
    partial class ParentContactTeacherControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentContactTeacherControl));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
            this.phoneNumberLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailLabel.Name = "emailLabel";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // ParentContactTeacherControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ParentContactTeacherControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}
