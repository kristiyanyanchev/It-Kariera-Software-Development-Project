namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentViewSubjectsForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.enrollSubjectForm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 70);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // enrollSubjectForm
            // 
            this.enrollSubjectForm.Location = new System.Drawing.Point(13, 12);
            this.enrollSubjectForm.Name = "enrollSubjectForm";
            this.enrollSubjectForm.Size = new System.Drawing.Size(75, 52);
            this.enrollSubjectForm.TabIndex = 2;
            this.enrollSubjectForm.Text = "Enroll Subject";
            this.enrollSubjectForm.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(94, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 225);
            this.listBox1.TabIndex = 3;
            // 
            // StudentViewSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.enrollSubjectForm);
            this.Controls.Add(this.closeButton);
            this.Name = "StudentViewSubjectsForm";
            this.Text = "StudentViewSubjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button enrollSubjectForm;
        private System.Windows.Forms.ListBox listBox1;
    }
}