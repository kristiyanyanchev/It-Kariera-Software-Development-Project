namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class TeacherAbsencesForm
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
            this.newAbsenceButton = new System.Windows.Forms.Button();
            this.removeAbsenceButton = new System.Windows.Forms.Button();
            this.classesListBox = new System.Windows.Forms.ListView();
            this.studentsListBox = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.isLateCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // newAbsenceButton
            // 
            this.newAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            this.newAbsenceButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.newAbsenceButton.Location = new System.Drawing.Point(462, 178);
            this.newAbsenceButton.Name = "newAbsenceButton";
            this.newAbsenceButton.Size = new System.Drawing.Size(100, 55);
            this.newAbsenceButton.TabIndex = 0;
            this.newAbsenceButton.Text = "New Absence";
            this.newAbsenceButton.UseVisualStyleBackColor = false;
            this.newAbsenceButton.Click += new System.EventHandler(this.newAbsenceButton_Click);
            // 
            // removeAbsenceButton
            // 
            this.removeAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            this.removeAbsenceButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.removeAbsenceButton.Location = new System.Drawing.Point(462, 284);
            this.removeAbsenceButton.Name = "removeAbsenceButton";
            this.removeAbsenceButton.Size = new System.Drawing.Size(100, 55);
            this.removeAbsenceButton.TabIndex = 1;
            this.removeAbsenceButton.Text = "Remove Absence";
            this.removeAbsenceButton.UseVisualStyleBackColor = false;
            this.removeAbsenceButton.Click += new System.EventHandler(this.removeAbsenceButton_Click);
            // 
            // classesListBox
            // 
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classesListBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.classesListBox.Location = new System.Drawing.Point(111, 56);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(137, 156);
            this.classesListBox.TabIndex = 2;
            this.classesListBox.UseCompatibleStateImageBehavior = false;
            // 
            // studentsListBox
            // 
            this.studentsListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.studentsListBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.studentsListBox.Location = new System.Drawing.Point(111, 246);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(137, 156);
            this.studentsListBox.TabIndex = 3;
            this.studentsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.Location = new System.Drawing.Point(462, 383);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 55);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // isLateCheckBox
            // 
            this.isLateCheckBox.AutoSize = true;
            this.isLateCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.isLateCheckBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.isLateCheckBox.Location = new System.Drawing.Point(462, 66);
            this.isLateCheckBox.Name = "isLateCheckBox";
            this.isLateCheckBox.Size = new System.Drawing.Size(65, 23);
            this.isLateCheckBox.TabIndex = 5;
            this.isLateCheckBox.Text = "Is Late";
            this.isLateCheckBox.UseVisualStyleBackColor = false;
            // 
            // TeacherAbsencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.isLateCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.removeAbsenceButton);
            this.Controls.Add(this.newAbsenceButton);
            this.Name = "TeacherAbsencesForm";
            this.Text = "TeacherAbsencesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newAbsenceButton;
        private System.Windows.Forms.Button removeAbsenceButton;
        private System.Windows.Forms.ListView classesListBox;
        private System.Windows.Forms.ListView studentsListBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox isLateCheckBox;
    }
}