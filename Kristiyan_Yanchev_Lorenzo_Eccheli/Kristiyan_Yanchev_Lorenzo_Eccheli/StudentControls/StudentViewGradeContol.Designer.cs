namespace Kristiyan_Yanchev_Lorenzo_Eccheli.StudentControls
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
            this.gradesDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.gradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Grade,
            this.Subject});
            this.gradesDataGrid.Location = new System.Drawing.Point(3, 22);
            this.gradesDataGrid.Name = "gradesDataGrid";
            this.gradesDataGrid.Size = new System.Drawing.Size(320, 328);
            this.gradesDataGrid.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // viewStatisticButton
            // 
            this.viewStatisticButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewStatisticButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.viewStatisticButton.Location = new System.Drawing.Point(384, 130);
            this.viewStatisticButton.Name = "viewStatisticButton";
            this.viewStatisticButton.Size = new System.Drawing.Size(125, 76);
            this.viewStatisticButton.TabIndex = 2;
            this.viewStatisticButton.Text = "View Statistics";
            this.viewStatisticButton.UseVisualStyleBackColor = false;
            this.viewStatisticButton.Click += new System.EventHandler(this.viewStatisticButton_Click);
            // 
            // StudentViewGradeContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.viewStatisticButton);
            this.Controls.Add(this.gradesDataGrid);
            this.Name = "StudentViewGradeContol";
            this.Size = new System.Drawing.Size(550, 370);
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gradesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Button viewStatisticButton;
    }
}
