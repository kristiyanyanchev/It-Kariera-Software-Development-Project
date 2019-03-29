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
            this.gradesDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.gradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Grade,
            this.Subject});
            this.gradesDataGrid.Location = new System.Drawing.Point(3, 97);
            this.gradesDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradesDataGrid.Name = "gradesDataGrid";
            this.gradesDataGrid.ReadOnly = true;
            this.gradesDataGrid.Size = new System.Drawing.Size(427, 404);
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
            this.viewStatisticButton.BackColor = System.Drawing.Color.FloralWhite;
            this.viewStatisticButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.viewStatisticButton.Location = new System.Drawing.Point(720, 390);
            this.viewStatisticButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewStatisticButton.Name = "viewStatisticButton";
            this.viewStatisticButton.Size = new System.Drawing.Size(167, 94);
            this.viewStatisticButton.TabIndex = 1;
            this.viewStatisticButton.Text = "View Statistics";
            this.viewStatisticButton.UseVisualStyleBackColor = false;
            this.viewStatisticButton.Click += new System.EventHandler(this.viewStatisticButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.Location = new System.Drawing.Point(720, 519);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(167, 94);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // StudentViewGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(903, 628);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewStatisticButton);
            this.Controls.Add(this.gradesDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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