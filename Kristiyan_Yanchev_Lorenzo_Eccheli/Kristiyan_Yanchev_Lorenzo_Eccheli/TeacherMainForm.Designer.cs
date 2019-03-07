namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class TeacherMainForm
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
            this.addgradeButton = new System.Windows.Forms.Button();
            this.gradeinfoButton = new System.Windows.Forms.Button();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTeacherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addgradeButton
            // 
            this.addgradeButton.Location = new System.Drawing.Point(12, 11);
            this.addgradeButton.Name = "addgradeButton";
            this.addgradeButton.Size = new System.Drawing.Size(82, 36);
            this.addgradeButton.TabIndex = 0;
            this.addgradeButton.Text = "Add Grade";
            this.addgradeButton.UseVisualStyleBackColor = true;
            // 
            // gradeinfoButton
            // 
            this.gradeinfoButton.Location = new System.Drawing.Point(226, 9);
            this.gradeinfoButton.Name = "gradeinfoButton";
            this.gradeinfoButton.Size = new System.Drawing.Size(81, 36);
            this.gradeinfoButton.TabIndex = 1;
            this.gradeinfoButton.Text = "Look Grade";
            this.gradeinfoButton.UseVisualStyleBackColor = true;
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Location = new System.Drawing.Point(139, 9);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(81, 36);
            this.searchStudentButton.TabIndex = 7;
            this.searchStudentButton.Text = "Search Student";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(431, 10);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(82, 38);
            this.changePasswordButton.TabIndex = 8;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(674, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTeacherButton
            // 
            this.searchTeacherButton.Location = new System.Drawing.Point(331, 10);
            this.searchTeacherButton.Name = "searchTeacherButton";
            this.searchTeacherButton.Size = new System.Drawing.Size(81, 34);
            this.searchTeacherButton.TabIndex = 10;
            this.searchTeacherButton.Text = "Search Teacher";
            this.searchTeacherButton.UseVisualStyleBackColor = true;
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 400);
            this.Controls.Add(this.searchTeacherButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.gradeinfoButton);
            this.Controls.Add(this.addgradeButton);
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addgradeButton;
        private System.Windows.Forms.Button gradeinfoButton;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchTeacherButton;
    }
}