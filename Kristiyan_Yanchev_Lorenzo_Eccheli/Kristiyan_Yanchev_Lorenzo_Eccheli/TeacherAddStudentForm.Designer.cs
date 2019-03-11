namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class TeacherAddStudentForm
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
            this.newStudentsListBox = new System.Windows.Forms.ListBox();
            this.addToClassButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newStudentsListBox
            // 
            this.newStudentsListBox.FormattingEnabled = true;
            this.newStudentsListBox.ItemHeight = 16;
            this.newStudentsListBox.Location = new System.Drawing.Point(559, 146);
            this.newStudentsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newStudentsListBox.Name = "newStudentsListBox";
            this.newStudentsListBox.Size = new System.Drawing.Size(163, 196);
            this.newStudentsListBox.TabIndex = 0;
            // 
            // addToClassButton
            // 
            this.addToClassButton.Location = new System.Drawing.Point(311, 343);
            this.addToClassButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addToClassButton.Name = "addToClassButton";
            this.addToClassButton.Size = new System.Drawing.Size(113, 54);
            this.addToClassButton.TabIndex = 1;
            this.addToClassButton.Text = "Add To Class";
            this.addToClassButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(622, 399);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 43);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // TeacherAddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 455);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addToClassButton);
            this.Controls.Add(this.newStudentsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherAddStudentForm";
            this.Text = "TeacherAddStudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox newStudentsListBox;
        private System.Windows.Forms.Button addToClassButton;
        private System.Windows.Forms.Button closeButton;
    }
}