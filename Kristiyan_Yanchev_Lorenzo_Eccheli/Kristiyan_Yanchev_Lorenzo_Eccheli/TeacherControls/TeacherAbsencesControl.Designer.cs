﻿namespace WinFormsView.TeacherControls
{
    partial class TeacherAbsencesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAbsencesControl));
            this.isLateCheckBox = new System.Windows.Forms.CheckBox();
            this.removeAbsenceButton = new System.Windows.Forms.Button();
            this.newAbsenceButton = new System.Windows.Forms.Button();
            this.classesLabel = new System.Windows.Forms.Label();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // isLateCheckBox
            // 
            resources.ApplyResources(this.isLateCheckBox, "isLateCheckBox");
            this.isLateCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.isLateCheckBox.Name = "isLateCheckBox";
            this.isLateCheckBox.UseVisualStyleBackColor = false;
            // 
            // removeAbsenceButton
            // 
            this.removeAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.removeAbsenceButton, "removeAbsenceButton");
            this.removeAbsenceButton.Name = "removeAbsenceButton";
            this.removeAbsenceButton.UseVisualStyleBackColor = false;
            this.removeAbsenceButton.Click += new System.EventHandler(this.removeAbsenceButton_Click);
            // 
            // newAbsenceButton
            // 
            this.newAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.newAbsenceButton, "newAbsenceButton");
            this.newAbsenceButton.Name = "newAbsenceButton";
            this.newAbsenceButton.UseVisualStyleBackColor = false;
            this.newAbsenceButton.Click += new System.EventHandler(this.newAbsenceButton_Click);
            // 
            // classesLabel
            // 
            resources.ApplyResources(this.classesLabel, "classesLabel");
            this.classesLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.classesLabel.Name = "classesLabel";
            // 
            // studentsLabel
            // 
            resources.ApplyResources(this.studentsLabel, "studentsLabel");
            this.studentsLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.studentsLabel.Name = "studentsLabel";
            // 
            // studentsListBox
            // 
            this.studentsListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.studentsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.studentsListBox, "studentsListBox");
            this.studentsListBox.Name = "studentsListBox";
            // 
            // classesListBox
            // 
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.classesListBox, "classesListBox");
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // TeacherAbsencesControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.studentsLabel);
            this.Controls.Add(this.classesLabel);
            this.Controls.Add(this.isLateCheckBox);
            this.Controls.Add(this.removeAbsenceButton);
            this.Controls.Add(this.newAbsenceButton);
            this.Name = "TeacherAbsencesControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isLateCheckBox;
        private System.Windows.Forms.Button removeAbsenceButton;
        private System.Windows.Forms.Button newAbsenceButton;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.ListBox classesListBox;
    }
}
