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
    public partial class E_Journal : Form
    {
        public E_Journal()
        {
            InitializeComponent();
            usernameTextBox.Focus();
        }

        private bool ValidateUsername()
        {
            if (usernameTextBox.Text != null) /*Look if exist in DB*/
            {
                return true;
            }
            return false;
        }

        private bool ValidatePassword()
        {
            if(passwordTextBox.Text!=null) /*Look if is true in DB*/
            {
                return true;
            }
            return false;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want really to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(usernameTextBox.Text!=null && passwordTextBox.Text!=null)
            {
                logInBtn.Enabled = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != null && passwordTextBox.Text != null)
            {
                logInBtn.Enabled = true;
            }
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(visibleCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
