namespace WinFormsView.StudentControls
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
            this.gradesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectSubjectButton = new System.Windows.Forms.Button();
            this.selectSubjectListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesChart
            // 
            this.gradesChart.BackColor = System.Drawing.Color.FloralWhite;
            this.gradesChart.BorderlineColor = System.Drawing.Color.FloralWhite;
            chartArea1.Name = "ChartArea1";
            this.gradesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gradesChart.Legends.Add(legend1);
            resources.ApplyResources(this.gradesChart, "gradesChart");
            this.gradesChart.Name = "gradesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gradesChart.Series.Add(series1);
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
            this.Controls.Add(this.gradesChart);
            this.Controls.Add(this.selectSubjectButton);
            this.Controls.Add(this.selectSubjectListbox);
            this.Name = "StudentGradeStatisticControl";
            ((System.ComponentModel.ISupportInitialize)(this.gradesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart gradesChart;
        private System.Windows.Forms.Button selectSubjectButton;
        private System.Windows.Forms.ListBox selectSubjectListbox;
    }
}
