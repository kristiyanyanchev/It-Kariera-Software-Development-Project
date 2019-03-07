namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class PrincipalValidationCodeForm
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
            this.roleListBox = new System.Windows.Forms.ListBox();
            this.validationTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.validationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roleListBox
            // 
            this.roleListBox.FormattingEnabled = true;
            this.roleListBox.Location = new System.Drawing.Point(216, 63);
            this.roleListBox.Name = "roleListBox";
            this.roleListBox.Size = new System.Drawing.Size(211, 186);
            this.roleListBox.TabIndex = 0;
            // 
            // validationTextBox
            // 
            this.validationTextBox.Location = new System.Drawing.Point(82, 63);
            this.validationTextBox.Name = "validationTextBox";
            this.validationTextBox.Size = new System.Drawing.Size(100, 20);
            this.validationTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(62, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 61);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(362, 356);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 61);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Location = new System.Drawing.Point(23, 66);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(53, 13);
            this.validationLabel.TabIndex = 4;
            this.validationLabel.Text = "Validation";
            // 
            // PrincipalValidationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 429);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.validationTextBox);
            this.Controls.Add(this.roleListBox);
            this.Name = "PrincipalValidationCodeForm";
            this.Text = "PrincipalValidationCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox roleListBox;
        private System.Windows.Forms.TextBox validationTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label validationLabel;
    }
}