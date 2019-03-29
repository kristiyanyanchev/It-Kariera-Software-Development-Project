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
            this.viewStatisticButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesDataGrid
            // 
            this.gradesDataGrid.AllowUserToAddRows = false;
            this.gradesDataGrid.AllowUserToDeleteRows = false;
            this.gradesDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.gradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gradesDataGrid, "gradesDataGrid");
            this.gradesDataGrid.Name = "gradesDataGrid";
            this.gradesDataGrid.ReadOnly = true;
            // 
            // viewStatisticButton
            // 
            this.viewStatisticButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.viewStatisticButton, "viewStatisticButton");
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
    }
}
