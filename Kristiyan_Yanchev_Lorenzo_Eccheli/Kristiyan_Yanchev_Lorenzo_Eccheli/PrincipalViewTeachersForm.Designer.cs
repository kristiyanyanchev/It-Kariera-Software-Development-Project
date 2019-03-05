namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class PrincipalViewTeachersForm
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
            this.teachersListbox = new System.Windows.Forms.ListBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teachersListbox
            // 
            this.teachersListbox.FormattingEnabled = true;
            this.teachersListbox.Location = new System.Drawing.Point(13, 13);
            this.teachersListbox.Name = "teachersListbox";
            this.teachersListbox.Size = new System.Drawing.Size(177, 355);
            this.teachersListbox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(208, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(409, 13);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(259, 40);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.ReadOnly = true;
            this.salaryTextBox.Size = new System.Drawing.Size(131, 20);
            this.salaryTextBox.TabIndex = 3;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(205, 43);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 4;
            this.salaryLabel.Text = "Salary";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(208, 66);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(182, 20);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(208, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(182, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(208, 118);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(182, 20);
            this.positionTextBox.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(208, 345);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(208, 316);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 9;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // PrincipalViewTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.teachersListbox);
            this.Name = "PrincipalViewTeachersForm";
            this.Text = "PrincipalViewTeachersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teachersListbox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button selectButton;
    }
}