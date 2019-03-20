namespace Kristiyan_Yanchev_Lorenzo_Eccheli.StudentControls
{
    partial class StudentViewAbsencesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentViewAbsencesControl));
            this.absencesDataGrid = new System.Windows.Forms.DataGridView();
            this.PeriodStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absencesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.absencesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // absencesDataGrid
            // 
            resources.ApplyResources(this.absencesDataGrid, "absencesDataGrid");
            this.absencesDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.absencesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absencesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeriodStartTime,
            this.PeriodEndTime,
            this.IsLate});
            this.absencesDataGrid.Name = "absencesDataGrid";
            // 
            // PeriodStartTime
            // 
            resources.ApplyResources(this.PeriodStartTime, "PeriodStartTime");
            this.PeriodStartTime.Name = "PeriodStartTime";
            this.PeriodStartTime.ReadOnly = true;
            // 
            // PeriodEndTime
            // 
            resources.ApplyResources(this.PeriodEndTime, "PeriodEndTime");
            this.PeriodEndTime.Name = "PeriodEndTime";
            this.PeriodEndTime.ReadOnly = true;
            // 
            // IsLate
            // 
            resources.ApplyResources(this.IsLate, "IsLate");
            this.IsLate.Name = "IsLate";
            this.IsLate.ReadOnly = true;
            // 
            // absencesLabel
            // 
            resources.ApplyResources(this.absencesLabel, "absencesLabel");
            this.absencesLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.absencesLabel.Name = "absencesLabel";
            // 
            // StudentViewAbsencesControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.absencesLabel);
            this.Controls.Add(this.absencesDataGrid);
            this.Name = "StudentViewAbsencesControl";
            ((System.ComponentModel.ISupportInitialize)(this.absencesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView absencesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLate;
        private System.Windows.Forms.Label absencesLabel;
    }
}
