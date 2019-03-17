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
            this.GradesChart.BackColor = System.Drawing.Color.FloralWhite;
            chartArea1.Name = "ChartArea1";
            this.GradesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GradesChart.Legends.Add(legend1);
            this.GradesChart.Location = new System.Drawing.Point(347, 44);
            this.GradesChart.Name = "GradesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GradesChart.Series.Add(series1);
            this.GradesChart.Size = new System.Drawing.Size(568, 289);
            this.GradesChart.TabIndex = 0;
            this.GradesChart.Text = "chart1";
            // 
            // selectSubjectListbox
            // 
            this.selectSubjectListbox.BackColor = System.Drawing.Color.FloralWhite;
            this.selectSubjectListbox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selectSubjectListbox.FormattingEnabled = true;
            this.selectSubjectListbox.ItemHeight = 19;
            this.selectSubjectListbox.Location = new System.Drawing.Point(127, 44);
            this.selectSubjectListbox.Name = "selectSubjectListbox";
            this.selectSubjectListbox.Size = new System.Drawing.Size(171, 289);
            this.selectSubjectListbox.TabIndex = 1;
            // 
            // selectSubjectButton
            // 
            this.selectSubjectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.selectSubjectButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selectSubjectButton.Location = new System.Drawing.Point(127, 387);
            this.selectSubjectButton.Name = "selectSubjectButton";
            this.selectSubjectButton.Size = new System.Drawing.Size(171, 66);
            this.selectSubjectButton.TabIndex = 2;
            this.selectSubjectButton.Text = "Select Subject";
            this.selectSubjectButton.UseVisualStyleBackColor = false;
            this.selectSubjectButton.Click += new System.EventHandler(this.selectSubjectButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.Location = new System.Drawing.Point(814, 437);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 68);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // StudentGradesStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(997, 517);
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