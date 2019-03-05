namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class PrincipalSubjectsForm
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
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.teachersListbox = new System.Windows.Forms.ListBox();
            this.addButtton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(13, 13);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(234, 420);
            this.subjectListBox.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(254, 13);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // teachersListbox
            // 
            this.teachersListbox.FormattingEnabled = true;
            this.teachersListbox.Location = new System.Drawing.Point(253, 169);
            this.teachersListbox.Name = "teachersListbox";
            this.teachersListbox.Size = new System.Drawing.Size(188, 264);
            this.teachersListbox.TabIndex = 2;
            // 
            // addButtton
            // 
            this.addButtton.Location = new System.Drawing.Point(254, 43);
            this.addButtton.Name = "addButtton";
            this.addButtton.Size = new System.Drawing.Size(75, 23);
            this.addButtton.TabIndex = 3;
            this.addButtton.Text = "Add";
            this.addButtton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(253, 72);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // PrincipalSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButtton);
            this.Controls.Add(this.teachersListbox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.subjectListBox);
            this.Name = "PrincipalSubjectsForm";
            this.Text = "PrincipalSubjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox teachersListbox;
        private System.Windows.Forms.Button addButtton;
        private System.Windows.Forms.Button closeButton;
    }
}