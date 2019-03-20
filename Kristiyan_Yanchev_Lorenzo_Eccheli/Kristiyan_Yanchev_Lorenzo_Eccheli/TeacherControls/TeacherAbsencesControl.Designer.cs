namespace Kristiyan_Yanchev_Lorenzo_Eccheli.TeacherControls
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
            this.studentsListBox = new System.Windows.Forms.ListView();
            this.classesListBox = new System.Windows.Forms.ListView();
            this.removeAbsenceButton = new System.Windows.Forms.Button();
            this.newAbsenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isLateCheckBox
            // 
            resources.ApplyResources(this.isLateCheckBox, "isLateCheckBox");
            this.isLateCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.isLateCheckBox.Name = "isLateCheckBox";
            this.isLateCheckBox.UseVisualStyleBackColor = false;
            // 
            // studentsListBox
            // 
            resources.ApplyResources(this.studentsListBox, "studentsListBox");
            this.studentsListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // classesListBox
            // 
            resources.ApplyResources(this.classesListBox, "classesListBox");
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.UseCompatibleStateImageBehavior = false;
            // 
            // removeAbsenceButton
            // 
            resources.ApplyResources(this.removeAbsenceButton, "removeAbsenceButton");
            this.removeAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            this.removeAbsenceButton.Name = "removeAbsenceButton";
            this.removeAbsenceButton.UseVisualStyleBackColor = false;
            // 
            // newAbsenceButton
            // 
            resources.ApplyResources(this.newAbsenceButton, "newAbsenceButton");
            this.newAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            this.newAbsenceButton.Name = "newAbsenceButton";
            this.newAbsenceButton.UseVisualStyleBackColor = false;
            // 
            // TeacherAbsencesControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.isLateCheckBox);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.removeAbsenceButton);
            this.Controls.Add(this.newAbsenceButton);
            this.Name = "TeacherAbsencesControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isLateCheckBox;
        private System.Windows.Forms.ListView studentsListBox;
        private System.Windows.Forms.ListView classesListBox;
        private System.Windows.Forms.Button removeAbsenceButton;
        private System.Windows.Forms.Button newAbsenceButton;
    }
}
