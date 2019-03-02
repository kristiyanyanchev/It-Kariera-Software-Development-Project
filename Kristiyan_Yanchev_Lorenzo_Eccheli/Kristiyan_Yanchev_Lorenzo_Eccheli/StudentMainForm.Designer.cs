namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentMainForm
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
            this.viewGradesButton = new System.Windows.Forms.Button();
            this.viewAbsencesButton = new System.Windows.Forms.Button();
            this.viewSubjectsButton = new System.Windows.Forms.Button();
            this.editInfoButton = new System.Windows.Forms.Button();
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.searchStudent = new System.Windows.Forms.Button();
            this.searchTeacher = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewGradesButton
            // 
            this.viewGradesButton.Location = new System.Drawing.Point(13, 25);
            this.viewGradesButton.Name = "viewGradesButton";
            this.viewGradesButton.Size = new System.Drawing.Size(81, 23);
            this.viewGradesButton.TabIndex = 0;
            this.viewGradesButton.Text = "Grades";
            this.viewGradesButton.UseVisualStyleBackColor = true;
            // 
            // viewAbsencesButton
            // 
            this.viewAbsencesButton.Location = new System.Drawing.Point(13, 54);
            this.viewAbsencesButton.Name = "viewAbsencesButton";
            this.viewAbsencesButton.Size = new System.Drawing.Size(81, 23);
            this.viewAbsencesButton.TabIndex = 1;
            this.viewAbsencesButton.Text = "Absences";
            this.viewAbsencesButton.UseVisualStyleBackColor = true;
            // 
            // viewSubjectsButton
            // 
            this.viewSubjectsButton.Location = new System.Drawing.Point(12, 83);
            this.viewSubjectsButton.Name = "viewSubjectsButton";
            this.viewSubjectsButton.Size = new System.Drawing.Size(82, 23);
            this.viewSubjectsButton.TabIndex = 2;
            this.viewSubjectsButton.Text = "Subjects";
            this.viewSubjectsButton.UseVisualStyleBackColor = true;
            // 
            // editInfoButton
            // 
            this.editInfoButton.Location = new System.Drawing.Point(13, 112);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(81, 38);
            this.editInfoButton.TabIndex = 3;
            this.editInfoButton.Text = "Edit Personal Information";
            this.editInfoButton.UseVisualStyleBackColor = true;
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.Location = new System.Drawing.Point(13, 156);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(82, 23);
            this.viewScheduleButton.TabIndex = 4;
            this.viewScheduleButton.Text = "Schedule";
            this.viewScheduleButton.UseVisualStyleBackColor = true;
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(13, 185);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(82, 38);
            this.changePassword.TabIndex = 5;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = true;
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(13, 230);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(81, 34);
            this.searchStudent.TabIndex = 6;
            this.searchStudent.Text = "Search Student";
            this.searchStudent.UseVisualStyleBackColor = true;
            // 
            // searchTeacher
            // 
            this.searchTeacher.Location = new System.Drawing.Point(14, 270);
            this.searchTeacher.Name = "searchTeacher";
            this.searchTeacher.Size = new System.Drawing.Size(81, 34);
            this.searchTeacher.TabIndex = 7;
            this.searchTeacher.Text = "Search Teacher";
            this.searchTeacher.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 311);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchTeacher);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.viewScheduleButton);
            this.Controls.Add(this.editInfoButton);
            this.Controls.Add(this.viewSubjectsButton);
            this.Controls.Add(this.viewAbsencesButton);
            this.Controls.Add(this.viewGradesButton);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewGradesButton;
        private System.Windows.Forms.Button viewAbsencesButton;
        private System.Windows.Forms.Button viewSubjectsButton;
        private System.Windows.Forms.Button editInfoButton;
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Button searchTeacher;
        private System.Windows.Forms.Button closeButton;
    }
}