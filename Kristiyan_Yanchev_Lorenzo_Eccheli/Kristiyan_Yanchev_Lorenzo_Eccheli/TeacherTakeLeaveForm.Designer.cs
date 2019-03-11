namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class TeacherTakeLeaveForm
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
            this.takeLeaveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startdateLabel = new System.Windows.Forms.Label();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takeLeaveButton
            // 
            this.takeLeaveButton.Location = new System.Drawing.Point(318, 243);
            this.takeLeaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.takeLeaveButton.Name = "takeLeaveButton";
            this.takeLeaveButton.Size = new System.Drawing.Size(111, 80);
            this.takeLeaveButton.TabIndex = 0;
            this.takeLeaveButton.Text = "Take Leave";
            this.takeLeaveButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(570, 304);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(111, 80);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Location = new System.Drawing.Point(337, 62);
            this.startDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.startDateDateTimePicker.TabIndex = 2;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Location = new System.Drawing.Point(337, 119);
            this.endDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.endDateDateTimePicker.TabIndex = 3;
            // 
            // startdateLabel
            // 
            this.startdateLabel.AutoSize = true;
            this.startdateLabel.Location = new System.Drawing.Point(100, 52);
            this.startdateLabel.Name = "startdateLabel";
            this.startdateLabel.Size = new System.Drawing.Size(72, 17);
            this.startdateLabel.TabIndex = 4;
            this.startdateLabel.Text = "Start Date";
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Location = new System.Drawing.Point(100, 119);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(37, 17);
            this.enddateLabel.TabIndex = 5;
            this.enddateLabel.Text = "End ";
            // 
            // TeacherTakeLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(694, 397);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.takeLeaveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherTakeLeaveForm";
            this.Text = "TeacherAnnualLeaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button takeLeaveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Label startdateLabel;
        private System.Windows.Forms.Label enddateLabel;
    }
}