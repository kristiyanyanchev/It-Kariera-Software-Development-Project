﻿namespace Kristiyan_Yanchev_Lorenzo_Eccheli
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
            this.newAbsenceButton.Location = new System.Drawing.Point(361, 280);
            this.newAbsenceButton.Margin = new System.Windows.Forms.Padding(4);
            this.newAbsenceButton.Name = "newAbsenceButton";
            this.newAbsenceButton.Size = new System.Drawing.Size(121, 57);
            this.newAbsenceButton.TabIndex = 0;
            this.newAbsenceButton.Text = "New Absence";
            this.newAbsenceButton.UseVisualStyleBackColor = false;
            this.newAbsenceButton.Click += new System.EventHandler(this.newAbsenceButton_Click);
            // 
            // removeAbsenceButton
            // 
            this.removeAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            this.removeAbsenceButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.removeAbsenceButton.Location = new System.Drawing.Point(361, 414);
            this.removeAbsenceButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeAbsenceButton.Name = "removeAbsenceButton";
            this.removeAbsenceButton.Size = new System.Drawing.Size(121, 57);
            this.removeAbsenceButton.TabIndex = 1;
            this.removeAbsenceButton.Text = "Remove Absence";
            this.removeAbsenceButton.UseVisualStyleBackColor = false;
            // 
            // classesListBox
            // 
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classesListBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.classesListBox.Location = new System.Drawing.Point(44, 58);
            this.classesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(181, 191);
            this.classesListBox.TabIndex = 2;
            this.classesListBox.UseCompatibleStateImageBehavior = false;
            // 
            // studentsListBox
            // 
            this.studentsListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.studentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.studentsListBox.Location = new System.Drawing.Point(44, 280);
            this.studentsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(181, 191);
            this.studentsListBox.TabIndex = 3;
            this.studentsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.Location = new System.Drawing.Point(538, 414);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(121, 57);
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
            this.isLateCheckBox.Location = new System.Drawing.Point(543, 49);
            this.isLateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.isLateCheckBox.Name = "isLateCheckBox";
            this.isLateCheckBox.Size = new System.Drawing.Size(79, 28);
            this.isLateCheckBox.TabIndex = 5;
            this.isLateCheckBox.Text = "Is Late";
            this.isLateCheckBox.UseVisualStyleBackColor = false;
            // 
            // TeacherAbsencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(672, 497);
            this.Controls.Add(this.isLateCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.removeAbsenceButton);
            this.Controls.Add(this.newAbsenceButton);
            this.Margin = new System.Windows.Forms.Padding(4);
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