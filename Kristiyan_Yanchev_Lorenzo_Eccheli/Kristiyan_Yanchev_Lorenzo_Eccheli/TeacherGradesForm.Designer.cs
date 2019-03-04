namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class TeacherGradesForm
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
            this.newGradeButton = new System.Windows.Forms.Button();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.studentsListbox = new System.Windows.Forms.ListBox();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.removeGradeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGradeButton
            // 
            this.newGradeButton.Location = new System.Drawing.Point(13, 13);
            this.newGradeButton.Name = "newGradeButton";
            this.newGradeButton.Size = new System.Drawing.Size(100, 23);
            this.newGradeButton.TabIndex = 0;
            this.newGradeButton.Text = "New Grade";
            this.newGradeButton.UseVisualStyleBackColor = true;
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(119, 13);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(127, 212);
            this.classesListBox.TabIndex = 1;
            // 
            // studentsListbox
            // 
            this.studentsListbox.FormattingEnabled = true;
            this.studentsListbox.Location = new System.Drawing.Point(268, 13);
            this.studentsListbox.Name = "studentsListbox";
            this.studentsListbox.Size = new System.Drawing.Size(130, 212);
            this.studentsListbox.TabIndex = 2;
            // 
            // gradesListBox
            // 
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.Location = new System.Drawing.Point(416, 12);
            this.gradesListBox.Name = "gradesListBox";
            this.gradesListBox.Size = new System.Drawing.Size(131, 212);
            this.gradesListBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // removeGradeButton
            // 
            this.removeGradeButton.Location = new System.Drawing.Point(13, 70);
            this.removeGradeButton.Name = "removeGradeButton";
            this.removeGradeButton.Size = new System.Drawing.Size(100, 23);
            this.removeGradeButton.TabIndex = 5;
            this.removeGradeButton.Text = "Remove Grade";
            this.removeGradeButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 99);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // TeacherGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 426);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.removeGradeButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gradesListBox);
            this.Controls.Add(this.studentsListbox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.newGradeButton);
            this.Name = "TeacherGradesForm";
            this.Text = "TeacherGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGradeButton;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.ListBox studentsListbox;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button removeGradeButton;
        private System.Windows.Forms.Button closeButton;
    }
}