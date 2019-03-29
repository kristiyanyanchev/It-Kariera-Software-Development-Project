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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGradesForm));
            this.newGradeButton = new System.Windows.Forms.Button();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.studentsListbox = new System.Windows.Forms.ListBox();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.removeGradeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // newGradeButton
            // 
            this.newGradeButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.newGradeButton, "newGradeButton");
            this.newGradeButton.Name = "newGradeButton";
            this.toolTip.SetToolTip(this.newGradeButton, resources.GetString("newGradeButton.ToolTip"));
            this.newGradeButton.UseVisualStyleBackColor = false;
            this.newGradeButton.Click += new System.EventHandler(this.newGradeButton_Click);
            // 
            // classesListBox
            // 
            this.classesListBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.classesListBox, "classesListBox");
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Name = "classesListBox";
            this.toolTip.SetToolTip(this.classesListBox, resources.GetString("classesListBox.ToolTip"));
            // 
            // studentsListbox
            // 
            this.studentsListbox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.studentsListbox, "studentsListbox");
            this.studentsListbox.FormattingEnabled = true;
            this.studentsListbox.Name = "studentsListbox";
            this.toolTip.SetToolTip(this.studentsListbox, resources.GetString("studentsListbox.ToolTip"));
            // 
            // gradesListBox
            // 
            this.gradesListBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.gradesListBox, "gradesListBox");
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.Name = "gradesListBox";
            this.toolTip.SetToolTip(this.gradesListBox, resources.GetString("gradesListBox.ToolTip"));
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.gradeTextBox, "gradeTextBox");
            this.gradeTextBox.Name = "gradeTextBox";
            this.toolTip.SetToolTip(this.gradeTextBox, resources.GetString("gradeTextBox.ToolTip"));
            // 
            // removeGradeButton
            // 
            this.removeGradeButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.removeGradeButton, "removeGradeButton");
            this.removeGradeButton.Name = "removeGradeButton";
            this.toolTip.SetToolTip(this.removeGradeButton, resources.GetString("removeGradeButton.ToolTip"));
            this.removeGradeButton.UseVisualStyleBackColor = false;
            this.removeGradeButton.Click += new System.EventHandler(this.removeGradeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.toolTip.SetToolTip(this.closeButton, resources.GetString("closeButton.ToolTip"));
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gradeLabel
            // 
            resources.ApplyResources(this.gradeLabel, "gradeLabel");
            this.gradeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.gradeLabel.Name = "gradeLabel";
            // 
            // instructionLabel
            // 
            resources.ApplyResources(this.instructionLabel, "instructionLabel");
            this.instructionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.instructionLabel.Name = "instructionLabel";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.toolTip.SetToolTip(this.languageComboBox, resources.GetString("languageComboBox.ToolTip"));
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // TeacherGradesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.removeGradeButton);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.gradesListBox);
            this.Controls.Add(this.studentsListbox);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.newGradeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TeacherGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGradeButton;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.ListBox studentsListbox;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Button removeGradeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}