namespace Kristiyan_Yanchev_Lorenzo_Eccheli.StudentControls
{
    partial class StudentGradeStatisticControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradeStatisticControl));
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GradesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectSubjectButton = new System.Windows.Forms.Button();
            this.selectSubjectListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GradesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GradesChart
            // 
            this.GradesChart.BackColor = System.Drawing.Color.FloralWhite;
            this.GradesChart.BorderlineColor = System.Drawing.Color.FloralWhite;
            chartArea1.Name = "ChartArea1";
            this.GradesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GradesChart.Legends.Add(legend1);
            resources.ApplyResources(this.GradesChart, "GradesChart");
            this.GradesChart.Name = "GradesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GradesChart.Series.Add(series1);
            // 
            // selectSubjectButton
            // 
            this.selectSubjectButton.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.selectSubjectButton, "selectSubjectButton");
            this.selectSubjectButton.Name = "selectSubjectButton";
            this.selectSubjectButton.UseVisualStyleBackColor = false;
            this.selectSubjectButton.Click += new System.EventHandler(this.selectSubjectButton_Click);
            // 
            // selectSubjectListbox
            // 
            this.selectSubjectListbox.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.selectSubjectListbox, "selectSubjectListbox");
            this.selectSubjectListbox.FormattingEnabled = true;
            this.selectSubjectListbox.Name = "selectSubjectListbox";
            // 
            // StudentGradeStatisticControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.GradesChart);
            this.Controls.Add(this.selectSubjectButton);
            this.Controls.Add(this.selectSubjectListbox);
            this.Name = "StudentGradeStatisticControl";
            ((System.ComponentModel.ISupportInitialize)(this.GradesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GradesChart;
        private System.Windows.Forms.Button selectSubjectButton;
        private System.Windows.Forms.ListBox selectSubjectListbox;
    }
}
