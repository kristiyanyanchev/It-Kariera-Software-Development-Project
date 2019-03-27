namespace Kristiyan_Yanchev_Lorenzo_Eccheli.RegistrationControls
{
    partial class StudentRegistrationControl
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
            this.ucnLabel = new System.Windows.Forms.Label();
            this.ucnTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.classnameTextBox = new System.Windows.Forms.TextBox();
            this.classnameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucnLabel
            // 
            this.ucnLabel.AutoSize = true;
            this.ucnLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.ucnLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ucnLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucnLabel.Location = new System.Drawing.Point(3, 58);
            this.ucnLabel.Name = "ucnLabel";
            this.ucnLabel.Size = new System.Drawing.Size(42, 24);
            this.ucnLabel.TabIndex = 26;
            this.ucnLabel.Text = "UCN";
            this.ucnLabel.Visible = false;
            // 
            // ucnTextBox
            // 
            this.ucnTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.ucnTextBox.Location = new System.Drawing.Point(187, 57);
            this.ucnTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucnTextBox.Name = "ucnTextBox";
            this.ucnTextBox.Size = new System.Drawing.Size(129, 22);
            this.ucnTextBox.TabIndex = 25;
            this.ucnTextBox.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.birthdayLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.birthdayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.birthdayLabel.Location = new System.Drawing.Point(3, 114);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(95, 24);
            this.birthdayLabel.TabIndex = 28;
            this.birthdayLabel.Text = "Day of birth";
            this.birthdayLabel.Visible = false;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Location = new System.Drawing.Point(187, 112);
            this.birthdatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(211, 22);
            this.birthdatePicker.TabIndex = 27;
            this.birthdatePicker.Visible = false;
            // 
            // classnameTextBox
            // 
            this.classnameTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.classnameTextBox.Location = new System.Drawing.Point(210, 162);
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
            this.classnameLabel.Location = new System.Drawing.Point(26, 162);
            this.classnameLabel.Name = "classnameLabel";
            this.classnameLabel.Size = new System.Drawing.Size(46, 24);
            this.classnameLabel.TabIndex = 29;
            this.classnameLabel.Text = "Class";
            this.classnameLabel.Visible = false;
            // 
            // StudentRegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.classnameTextBox);
            this.Controls.Add(this.classnameLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.ucnLabel);
            this.Controls.Add(this.ucnTextBox);
            this.Name = "StudentRegistrationControl";
            this.Size = new System.Drawing.Size(423, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucnLabel;
        private System.Windows.Forms.TextBox ucnTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.TextBox classnameTextBox;
        private System.Windows.Forms.Label classnameLabel;
    }
}
