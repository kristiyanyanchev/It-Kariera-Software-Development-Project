namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class StudentScheludeForm
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
            this.scheludeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // scheludeListBox
            // 
            this.scheludeListBox.FormattingEnabled = true;
            this.scheludeListBox.Location = new System.Drawing.Point(57, 44);
            this.scheludeListBox.Name = "scheludeListBox";
            this.scheludeListBox.Size = new System.Drawing.Size(120, 95);
            this.scheludeListBox.TabIndex = 0;
            // 
            // StudentScheludeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheludeListBox);
            this.Name = "StudentScheludeForm";
            this.Text = "StudentScheludeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox scheludeListBox;
    }
}