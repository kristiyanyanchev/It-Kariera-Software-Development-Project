namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentGradesStatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GradesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectSubjectListbox = new System.Windows.Forms.ListBox();
            this.selectSubjectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GradesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GradesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GradesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GradesChart.Legends.Add(legend1);
            this.GradesChart.Location = new System.Drawing.Point(190, 4);
            this.GradesChart.Name = "GradesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GradesChart.Series.Add(series1);
            this.GradesChart.Size = new System.Drawing.Size(685, 300);
            this.GradesChart.TabIndex = 0;
            this.GradesChart.Text = "chart1";
            // 
            // selectSubjectListbox
            // 
            this.selectSubjectListbox.FormattingEnabled = true;
            this.selectSubjectListbox.Location = new System.Drawing.Point(13, 14);
            this.selectSubjectListbox.Name = "selectSubjectListbox";
            this.selectSubjectListbox.Size = new System.Drawing.Size(171, 290);
            this.selectSubjectListbox.TabIndex = 1;
            // 
            // selectSubjectButton
            // 
            this.selectSubjectButton.Location = new System.Drawing.Point(13, 310);
            this.selectSubjectButton.Name = "selectSubjectButton";
            this.selectSubjectButton.Size = new System.Drawing.Size(171, 23);
            this.selectSubjectButton.TabIndex = 2;
            this.selectSubjectButton.Text = "Select Subject";
            this.selectSubjectButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 340);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // StudentGradesStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectSubjectButton);
            this.Controls.Add(this.selectSubjectListbox);
            this.Controls.Add(this.GradesChart);
            this.Name = "StudentGradesStatisticsForm";
            this.Text = "StudentGradesStatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.GradesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GradesChart;
        private System.Windows.Forms.ListBox selectSubjectListbox;
        private System.Windows.Forms.Button selectSubjectButton;
        private System.Windows.Forms.Button closeButton;
    }
}