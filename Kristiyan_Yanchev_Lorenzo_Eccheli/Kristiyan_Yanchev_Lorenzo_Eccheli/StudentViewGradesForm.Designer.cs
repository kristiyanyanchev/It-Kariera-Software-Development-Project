namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentViewGradesForm
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
            this.gradesDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewStatisticButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesDataGrid
            // 
            this.gradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Grade,
            this.Subject});
            this.gradesDataGrid.Location = new System.Drawing.Point(144, 12);
            this.gradesDataGrid.Name = "gradesDataGrid";
            this.gradesDataGrid.Size = new System.Drawing.Size(343, 328);
            this.gradesDataGrid.TabIndex = 0;
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
            this.viewStatisticButton.Location = new System.Drawing.Point(13, 13);
            this.viewStatisticButton.Name = "viewStatisticButton";
            this.viewStatisticButton.Size = new System.Drawing.Size(125, 23);
            this.viewStatisticButton.TabIndex = 1;
            this.viewStatisticButton.Text = "View Statistics";
            this.viewStatisticButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 43);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // StudentViewGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 401);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewStatisticButton);
            this.Controls.Add(this.gradesDataGrid);
            this.Name = "StudentViewGradesForm";
            this.Text = "StudentViewGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gradesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Button viewStatisticButton;
        private System.Windows.Forms.Button closeButton;
    }
}