namespace Kristiyan_Yanchev_Lorenzo_Eccheli.RegistrationControls
{
    partial class TeacherRegistrationControl
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
            this.classnameTextBox = new System.Windows.Forms.TextBox();
            this.classnameLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classnameTextBox
            // 
            this.classnameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classnameTextBox.Location = new System.Drawing.Point(201, 55);
            this.classnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classnameTextBox.Name = "classnameTextBox";
            this.classnameTextBox.Size = new System.Drawing.Size(129, 22);
            this.classnameTextBox.TabIndex = 30;
            this.classnameTextBox.Visible = false;
            // 
            // classnameLabel
            // 
            this.classnameLabel.AutoSize = true;
            this.classnameLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.classnameLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.classnameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.classnameLabel.Location = new System.Drawing.Point(17, 55);
            this.classnameLabel.Name = "classnameLabel";
            this.classnameLabel.Size = new System.Drawing.Size(46, 24);
            this.classnameLabel.TabIndex = 29;
            this.classnameLabel.Text = "Class";
            this.classnameLabel.Visible = false;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.subjectTextBox.Location = new System.Drawing.Point(201, 114);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(129, 22);
            this.subjectTextBox.TabIndex = 39;
            this.subjectTextBox.Visible = false;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.subjectLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.subjectLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.subjectLabel.Location = new System.Drawing.Point(17, 114);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(62, 24);
            this.subjectLabel.TabIndex = 38;
            this.subjectLabel.Text = "Subject";
            this.subjectLabel.Visible = false;
            // 
            // positionTextBox
            // 
            this.positionTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.positionTextBox.Location = new System.Drawing.Point(201, 167);
            this.positionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(129, 22);
            this.positionTextBox.TabIndex = 41;
            this.positionTextBox.Visible = false;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.positionLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.positionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.positionLabel.Location = new System.Drawing.Point(17, 165);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(67, 24);
            this.positionLabel.TabIndex = 40;
            this.positionLabel.Text = "Position";
            this.positionLabel.Visible = false;
            // 
            // TeacherRegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.classnameTextBox);
            this.Controls.Add(this.classnameLabel);
            this.Name = "TeacherRegistrationControl";
            this.Size = new System.Drawing.Size(347, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classnameTextBox;
        private System.Windows.Forms.Label classnameLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label positionLabel;
    }
}
