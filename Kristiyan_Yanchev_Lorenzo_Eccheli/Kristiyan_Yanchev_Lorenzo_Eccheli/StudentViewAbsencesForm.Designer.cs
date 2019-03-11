namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentViewAbsencesForm
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
            this.absencesDataGrid = new System.Windows.Forms.DataGridView();
            this.PeriodStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.absencesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // absencesDataGrid
            // 
            this.absencesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absencesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeriodStartTime,
            this.PeriodEndTime,
            this.IsLate});
            this.absencesDataGrid.Location = new System.Drawing.Point(151, 12);
            this.absencesDataGrid.Name = "absencesDataGrid";
            this.absencesDataGrid.Size = new System.Drawing.Size(343, 405);
            this.absencesDataGrid.TabIndex = 0;
            // 
            // PeriodStartTime
            // 
            this.PeriodStartTime.HeaderText = "Period Start Time";
            this.PeriodStartTime.Name = "PeriodStartTime";
            this.PeriodStartTime.ReadOnly = true;
            // 
            // PeriodEndTime
            // 
            this.PeriodEndTime.HeaderText = "Period End Time";
            this.PeriodEndTime.Name = "PeriodEndTime";
            this.PeriodEndTime.ReadOnly = true;
            // 
            // IsLate
            // 
            this.IsLate.HeaderText = "Is Late";
            this.IsLate.Name = "IsLate";
            this.IsLate.ReadOnly = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(13, 29);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(109, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // StudentViewAbsencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.absencesDataGrid);
            this.Name = "StudentViewAbsencesForm";
            this.Text = "StudentViewAbsencesForm";
            ((System.ComponentModel.ISupportInitialize)(this.absencesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView absencesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLate;
        private System.Windows.Forms.Button CloseButton;
    }
}