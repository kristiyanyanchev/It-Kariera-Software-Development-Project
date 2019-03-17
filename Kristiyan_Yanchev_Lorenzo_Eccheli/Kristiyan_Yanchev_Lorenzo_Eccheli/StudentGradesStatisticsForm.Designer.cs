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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradesStatisticsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GradesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectSubjectListbox = new System.Windows.Forms.ListBox();
            this.selectSubjectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GradesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GradesChart
            // 
            resources.ApplyResources(this.GradesChart, "GradesChart");
            this.GradesChart.BackColor = System.Drawing.Color.FloralWhite;
            this.GradesChart.BorderlineColor = System.Drawing.Color.FloralWhite;
            chartArea2.Name = "ChartArea1";
            this.GradesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GradesChart.Legends.Add(legend2);
            this.GradesChart.Name = "GradesChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GradesChart.Series.Add(series2);
            this.toolTip.SetToolTip(this.GradesChart, resources.GetString("GradesChart.ToolTip"));
            // 
            // selectSubjectListbox
            // 
            resources.ApplyResources(this.selectSubjectListbox, "selectSubjectListbox");
            this.selectSubjectListbox.BackColor = System.Drawing.Color.FloralWhite;
            this.selectSubjectListbox.FormattingEnabled = true;
            this.selectSubjectListbox.Name = "selectSubjectListbox";
            this.toolTip.SetToolTip(this.selectSubjectListbox, resources.GetString("selectSubjectListbox.ToolTip"));
            // 
            // selectSubjectButton
            // 
            resources.ApplyResources(this.selectSubjectButton, "selectSubjectButton");
            this.selectSubjectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.selectSubjectButton.Name = "selectSubjectButton";
            this.toolTip.SetToolTip(this.selectSubjectButton, resources.GetString("selectSubjectButton.ToolTip"));
            this.selectSubjectButton.UseVisualStyleBackColor = false;
            this.selectSubjectButton.Click += new System.EventHandler(this.selectSubjectButton_Click);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Name = "closeButton";
            this.toolTip.SetToolTip(this.closeButton, resources.GetString("closeButton.ToolTip"));
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.BackColor = System.Drawing.Color.FloralWhite;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            this.languageComboBox.Name = "languageComboBox";
            this.toolTip.SetToolTip(this.languageComboBox, resources.GetString("languageComboBox.ToolTip"));
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.languageLabel.Name = "languageLabel";
            this.toolTip.SetToolTip(this.languageLabel, resources.GetString("languageLabel.ToolTip"));
            // 
            // StudentGradesStatisticsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectSubjectButton);
            this.Controls.Add(this.selectSubjectListbox);
            this.Controls.Add(this.GradesChart);
            this.Name = "StudentGradesStatisticsForm";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.GradesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GradesChart;
        private System.Windows.Forms.ListBox selectSubjectListbox;
        private System.Windows.Forms.Button selectSubjectButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}