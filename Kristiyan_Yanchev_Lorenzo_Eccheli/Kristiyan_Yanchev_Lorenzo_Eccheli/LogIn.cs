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
            Registration registration = new Registration(languageComboBox.SelectedItem.ToString());
            registration.ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(dialog==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(passwordTextBox.Text!=null)
            {
                logInBtn.Enabled = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if(usernameTextBox.Text!=null)
            {
                logInBtn.Enabled = true;
            }
        }

        private void visiblepasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(visiblepasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(languageComboBox.SelectedItem.ToString()=="English")
            {
                this.Text = "School E-journal";
                languageLabel.Text = "Language";
                introductionLabel.Text = "Welcome to the school E-Journal";
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                logInBtn.Text = "Log in";
                registerBtn.Text = "Register";
                exitBtn.Text = "Exit";
            }
            else if(languageComboBox.SelectedItem.ToString()=="Bulgarian")
            {
                this.Text = "Електроният училищен дневник";
                languageLabel.Text = "Език";
                introductionLabel.Text = "Добре дошли в електрония училищен дневник";
                usernameLabel.Text = "Име";
                passwordLabel.Text = "Парола";
                logInBtn.Text = "Влизане";
                registerBtn.Text = "Регистрация";
                exitBtn.Text = "Изход";
            }
        }
    }
}
