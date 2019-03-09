namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    partial class PrincipalBonusesForm
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
            this.teachersListBox = new System.Windows.Forms.ListBox();
            this.bonusButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teachersListBox
            // 
            this.teachersListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.teachersListBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.teachersListBox.FormattingEnabled = true;
            this.teachersListBox.ItemHeight = 19;
            this.teachersListBox.Location = new System.Drawing.Point(74, 96);
            this.teachersListBox.Name = "teachersListBox";
            this.teachersListBox.Size = new System.Drawing.Size(175, 289);
            this.teachersListBox.TabIndex = 0;
            // 
            // bonusButton
            // 
            this.bonusButton.BackColor = System.Drawing.Color.FloralWhite;
            this.bonusButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bonusButton.Location = new System.Drawing.Point(379, 135);
            this.bonusButton.Name = "bonusButton";
            this.bonusButton.Size = new System.Drawing.Size(80, 51);
            this.bonusButton.TabIndex = 1;
            this.bonusButton.Text = "Add Bonus";
            this.bonusButton.UseVisualStyleBackColor = false;
            this.bonusButton.Click += new System.EventHandler(this.bonusButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.Location = new System.Drawing.Point(472, 318);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 70);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.amountTextBox.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.amountTextBox.Location = new System.Drawing.Point(412, 96);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 24);
            this.amountTextBox.TabIndex = 10;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.amountLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.amountLabel.Location = new System.Drawing.Point(351, 96);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 19);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "Amount";
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.introductionLabel.Font = new System.Drawing.Font("Sitka Heading", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.introductionLabel.Location = new System.Drawing.Point(150, 19);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(254, 28);
            this.introductionLabel.TabIndex = 12;
            this.introductionLabel.Text = "Add a bonus to your workers";
            // 
            // PrincipalBonusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kristiyan_Yanchev_Lorenzo_Eccheli.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bonusButton);
            this.Controls.Add(this.teachersListBox);
            this.Name = "PrincipalBonusesForm";
            this.Text = "Bonuses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalBonusesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teachersListBox;
        private System.Windows.Forms.Button bonusButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label introductionLabel;
    }
}