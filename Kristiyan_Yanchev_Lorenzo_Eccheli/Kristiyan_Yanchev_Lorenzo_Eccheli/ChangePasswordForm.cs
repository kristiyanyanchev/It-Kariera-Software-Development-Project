using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(string language)
        {

            if (language == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
        }
        
        private bool ValidateData()
        {
            if(oldPasswordTextBox.Text!=null && newPasswordTextBox.Text!=null &&
                confirmNewPasswordTextBox.Text!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleCheckBox.Checked)
            {
                newPasswordTextBox.PasswordChar = '\0';
                confirmNewPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                newPasswordTextBox.PasswordChar = '*';
                confirmNewPasswordTextBox.PasswordChar = '*';
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (languageComboBox.SelectedItem.ToString() == "English" ||
                languageComboBox.SelectedItem.ToString() == "Английски")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
        }
    }
}
