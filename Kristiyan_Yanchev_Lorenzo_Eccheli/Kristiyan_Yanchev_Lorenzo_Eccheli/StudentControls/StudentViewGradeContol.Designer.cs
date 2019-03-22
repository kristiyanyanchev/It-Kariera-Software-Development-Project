namespace WinFormsView.StudentControls
{
    partial class StudentViewGradeContol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentViewGradeContol));
            this.gradesDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewStatisticButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesDataGrid
            // 
            resources.ApplyResources(this.gradesDataGrid, "gradesDataGrid");
            this.gradesDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.gradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Grade,
            this.Subject});
            this.gradesDataGrid.Name = "gradesDataGrid";
            // 
            // Date
            // 
            resources.ApplyResources(this.Date, "Date");
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Grade
            // 
            resources.ApplyResources(this.Grade, "Grade");
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Subject
            // 
            resources.ApplyResources(this.Subject, "Subject");
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // viewStatisticButton
            // 
            resources.ApplyResources(this.viewStatisticButton, "viewStatisticButton");
            this.viewStatisticButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewStatisticButton.Name = "viewStatisticButton";
            this.viewStatisticButton.UseVisualStyleBackColor = false;
            this.viewStatisticButton.Click += new System.EventHandler(this.viewStatisticButton_Click);
            // 
            // StudentViewGradeContol
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.viewStatisticButton);
            this.Controls.Add(this.gradesDataGrid);
            this.Name = "StudentViewGradeContol";
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gradesDataGrid;
        private System.Windows.Forms.Button viewStatisticButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
    }
}
