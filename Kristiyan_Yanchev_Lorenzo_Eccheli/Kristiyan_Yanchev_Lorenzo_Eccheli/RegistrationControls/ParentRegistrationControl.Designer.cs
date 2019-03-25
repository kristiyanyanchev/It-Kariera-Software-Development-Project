namespace Kristiyan_Yanchev_Lorenzo_Eccheli.RegistrationControls
{
    partial class ParentRegistrationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentRegistrationControl));
            this.usernameOfChildTextBox = new System.Windows.Forms.TextBox();
            this.usernameOfChildLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameOfChildTextBox
            // 
            resources.ApplyResources(this.usernameOfChildTextBox, "usernameOfChildTextBox");
            this.usernameOfChildTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.usernameOfChildTextBox.Name = "usernameOfChildTextBox";
            // 
            // usernameOfChildLabel
            // 
            resources.ApplyResources(this.usernameOfChildLabel, "usernameOfChildLabel");
            this.usernameOfChildLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.usernameOfChildLabel.Name = "usernameOfChildLabel";
            // 
            // ParentRegistrationControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.usernameOfChildLabel);
            this.Controls.Add(this.usernameOfChildTextBox);
            this.Name = "ParentRegistrationControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameOfChildTextBox;
        private System.Windows.Forms.Label usernameOfChildLabel;
    }
}
