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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAbsencesForm));
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
            resources.ApplyResources(this.newAbsenceButton, "newAbsenceButton");
            this.newAbsenceButton.Name = "newAbsenceButton";
            this.newAbsenceButton.UseVisualStyleBackColor = false;
            this.newAbsenceButton.Click += new System.EventHandler(this.newAbsenceButton_Click);
            // 
            // removeAbsenceButton
            // 
            this.removeAbsenceButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.removeAbsenceButton, "removeAbsenceButton");
            this.removeAbsenceButton.Name = "removeAbsenceButton";
            this.removeAbsenceButton.UseVisualStyleBackColor = false;
            this.removeAbsenceButton.Click += new System.EventHandler(this.removeAbsenceButton_Click);
            // 
            // classesListBox
            // 
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.classesListBox, "classesListBox");
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.UseCompatibleStateImageBehavior = false;
            // 
            // studentsListBox
            // 
            this.studentsListBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.studentsListBox, "studentsListBox");
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // isLateCheckBox
            // 
            resources.ApplyResources(this.isLateCheckBox, "isLateCheckBox");
            this.isLateCheckBox.BackColor = System.Drawing.Color.FloralWhite;
            this.isLateCheckBox.Name = "isLateCheckBox";
            this.isLateCheckBox.UseVisualStyleBackColor = false;
            // 
            // TeacherAbsencesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.isLateCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.removeAbsenceButton);
            this.Controls.Add(this.newAbsenceButton);
            this.Name = "TeacherAbsencesForm";
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