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
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.searchStudent = new System.Windows.Forms.Button();
            this.searchTeacher = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.viewGradesButton.Click += new System.EventHandler(this.viewGradesButton_Click);
            // 
            // viewAbsencesButton
            // 
            this.viewAbsencesButton.Location = new System.Drawing.Point(13, 54);
            this.viewAbsencesButton.Name = "viewAbsencesButton";
            this.viewAbsencesButton.Size = new System.Drawing.Size(81, 23);
            this.viewAbsencesButton.TabIndex = 1;
            this.viewAbsencesButton.Text = "Absences";
            this.viewAbsencesButton.UseVisualStyleBackColor = true;
            this.viewAbsencesButton.Click += new System.EventHandler(this.viewAbsencesButton_Click);
            // 
            // viewSubjectsButton
            // 
            this.viewSubjectsButton.Location = new System.Drawing.Point(12, 83);
            this.viewSubjectsButton.Name = "viewSubjectsButton";
            this.viewSubjectsButton.Size = new System.Drawing.Size(82, 23);
            this.viewSubjectsButton.TabIndex = 2;
            this.viewSubjectsButton.Text = "Subjects";
            this.viewSubjectsButton.UseVisualStyleBackColor = true;
            this.viewSubjectsButton.Click += new System.EventHandler(this.viewSubjectsButton_Click);
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.Location = new System.Drawing.Point(12, 112);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(82, 23);
            this.viewScheduleButton.TabIndex = 4;
            this.viewScheduleButton.Text = "Schedule";
            this.viewScheduleButton.UseVisualStyleBackColor = true;
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(12, 141);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(82, 38);
            this.changePassword.TabIndex = 5;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(13, 185);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(81, 34);
            this.searchStudent.TabIndex = 6;
            this.searchStudent.Text = "Search Student";
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // searchTeacher
            // 
            this.searchTeacher.Location = new System.Drawing.Point(12, 225);
            this.searchTeacher.Name = "searchTeacher";
            this.searchTeacher.Size = new System.Drawing.Size(81, 34);
            this.searchTeacher.TabIndex = 7;
            this.searchTeacher.Text = "Search Teacher";
            this.searchTeacher.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(481, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 352);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchTeacher);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.viewScheduleButton);
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
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Button searchTeacher;
        private System.Windows.Forms.Button exitButton;
    }
}