using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        
        private bool ValidateData()
        {
            if(oldPasswordTextBox.Text!=null && newPasswordTextBox.Text!=null &&
                confirmNewPasswordTextBox.Text!=null &&
                confirmNewPasswordTextBox.Text==newPasswordTextBox.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
            //мойе да даде грешка
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

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
