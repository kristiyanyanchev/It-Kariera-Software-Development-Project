﻿namespace Kristiyan_Yanchev_Lorenzo_Eccheli.TeacherControls
{
    partial class TeacherGradeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGradeControl));
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.removeGradeButton = new System.Windows.Forms.Button();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.studentsListbox = new System.Windows.Forms.ListBox();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.newGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            this.languageComboBox.Name = "languageComboBox";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            // 
            // gradeLabel
            // 
            resources.ApplyResources(this.gradeLabel, "gradeLabel");
            this.gradeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeLabel.Name = "gradeLabel";
            // 
            // removeGradeButton
            // 
            resources.ApplyResources(this.removeGradeButton, "removeGradeButton");
            this.removeGradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.removeGradeButton.Name = "removeGradeButton";
            this.removeGradeButton.UseVisualStyleBackColor = false;
            // 
            // gradeTextBox
            // 
            resources.ApplyResources(this.gradeTextBox, "gradeTextBox");
            this.gradeTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeTextBox.Name = "gradeTextBox";
            // 
            // gradesListBox
            // 
            resources.ApplyResources(this.gradesListBox, "gradesListBox");
            this.gradesListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.Name = "gradesListBox";
            // 
            // studentsListbox
            // 
            resources.ApplyResources(this.studentsListbox, "studentsListbox");
            this.studentsListbox.BackColor = System.Drawing.Color.FloralWhite;
            this.studentsListbox.FormattingEnabled = true;
            this.studentsListbox.Name = "studentsListbox";
            // 
            // classesListBox
            // 
            resources.ApplyResources(this.classesListBox, "classesListBox");
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Name = "classesListBox";
            // 
            // newGradeButton
            // 
            resources.ApplyResources(this.newGradeButton, "newGradeButton");
            this.newGradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.newGradeButton.Name = "newGradeButton";
            this.newGradeButton.UseVisualStyleBackColor = false;
            // 
            // TeacherGradeControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.removeGradeButton);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.gradesListBox);
            this.Controls.Add(this.studentsListbox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.newGradeButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Name = "TeacherGradeControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button removeGradeButton;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.ListBox studentsListbox;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Button newGradeButton;
    }
}
