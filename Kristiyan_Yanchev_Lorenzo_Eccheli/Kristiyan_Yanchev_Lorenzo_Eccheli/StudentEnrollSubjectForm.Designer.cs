namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentEnrollSubjectForm
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
            this.enrollSubjectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.subjectListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // enrollSubjectButton
            // 
            this.enrollSubjectButton.Location = new System.Drawing.Point(13, 13);
            this.enrollSubjectButton.Name = "enrollSubjectButton";
            this.enrollSubjectButton.Size = new System.Drawing.Size(75, 59);
            this.enrollSubjectButton.TabIndex = 0;
            this.enrollSubjectButton.Text = "Enroll Selected Subject";
            this.enrollSubjectButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 79);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // subjectListbox
            // 
            this.subjectListbox.FormattingEnabled = true;
            this.subjectListbox.Location = new System.Drawing.Point(111, 13);
            this.subjectListbox.Name = "subjectListbox";
            this.subjectListbox.Size = new System.Drawing.Size(220, 225);
            this.subjectListbox.TabIndex = 2;
            // 
            // EnrollSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectListbox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enrollSubjectButton);
            this.Name = "EnrollSubjectForm";
            this.Text = "EnrollSubjectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enrollSubjectButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox subjectListbox;
    }
}