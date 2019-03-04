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
            this.gradesButton = new System.Windows.Forms.Button();
            this.absencesButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.takeAnnualLeaveButton = new System.Windows.Forms.Button();
            this.takeSickLeave = new System.Windows.Forms.Button();
            this.viewStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradesButton
            // 
            this.gradesButton.Location = new System.Drawing.Point(13, 13);
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.Size = new System.Drawing.Size(75, 23);
            this.gradesButton.TabIndex = 0;
            this.gradesButton.Text = "Grades";
            this.gradesButton.UseVisualStyleBackColor = true;
            // 
            // absencesButton
            // 
            this.absencesButton.Location = new System.Drawing.Point(12, 42);
            this.absencesButton.Name = "absencesButton";
            this.absencesButton.Size = new System.Drawing.Size(75, 23);
            this.absencesButton.TabIndex = 1;
            this.absencesButton.Text = "Absences";
            this.absencesButton.UseVisualStyleBackColor = true;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(13, 71);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(75, 38);
            this.changePasswordButton.TabIndex = 2;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(13, 116);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 42);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            // 
            // takeAnnualLeaveButton
            // 
            this.takeAnnualLeaveButton.Location = new System.Drawing.Point(13, 164);
            this.takeAnnualLeaveButton.Name = "takeAnnualLeaveButton";
            this.takeAnnualLeaveButton.Size = new System.Drawing.Size(75, 47);
            this.takeAnnualLeaveButton.TabIndex = 4;
            this.takeAnnualLeaveButton.Text = "Take Annual Leave";
            this.takeAnnualLeaveButton.UseVisualStyleBackColor = true;
            // 
            // takeSickLeave
            // 
            this.takeSickLeave.Location = new System.Drawing.Point(13, 217);
            this.takeSickLeave.Name = "takeSickLeave";
            this.takeSickLeave.Size = new System.Drawing.Size(75, 47);
            this.takeSickLeave.TabIndex = 5;
            this.takeSickLeave.Text = "Take Sick Leave";
            this.takeSickLeave.UseVisualStyleBackColor = true;
            // 
            // viewStudentButton
            // 
            this.viewStudentButton.Location = new System.Drawing.Point(13, 271);
            this.viewStudentButton.Name = "viewStudentButton";
            this.viewStudentButton.Size = new System.Drawing.Size(75, 35);
            this.viewStudentButton.TabIndex = 6;
            this.viewStudentButton.Text = "View Student";
            this.viewStudentButton.UseVisualStyleBackColor = true;
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewStudentButton);
            this.Controls.Add(this.takeSickLeave);
            this.Controls.Add(this.takeAnnualLeaveButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.absencesButton);
            this.Controls.Add(this.gradesButton);
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Button absencesButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button takeAnnualLeaveButton;
        private System.Windows.Forms.Button takeSickLeave;
        private System.Windows.Forms.Button viewStudentButton;
    }
}