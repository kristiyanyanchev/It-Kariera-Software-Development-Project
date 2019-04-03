namespace WinFormsView.ParentControls
{
    partial class ParentViewGradeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentViewGradeControl));
            this.gradesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesDataGrid
            // 
            resources.ApplyResources(this.gradesDataGrid, "gradesDataGrid");
            this.gradesDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.gradesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGrid.Name = "gradesDataGrid";
            // 
            // ParentViewGradeControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.gradesDataGrid);
            this.Name = "ParentViewGradeControl";
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gradesDataGrid;
    }
}
