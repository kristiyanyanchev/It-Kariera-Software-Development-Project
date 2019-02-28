﻿using System;
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
                Application.ExitThread();
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
                visiblepasswordCheckBox.Text = "Visible";
                introductionLabel.Text = "Welcome to the school E-Journal";
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                logInBtn.Text = "Log in";
                registerBtn.Text = "Register";
                exitBtn.Text = "Exit";
                formToolTip.SetToolTip(usernameTextBox, "Enter your first name.");
                formToolTip.SetToolTip(passwordTextBox, "Enter your account password.");
                formToolTip.SetToolTip(registerBtn, "Make new E-journal account.");
                formToolTip.SetToolTip(logInBtn, "Log in into an existing account.");
                formToolTip.SetToolTip(visiblepasswordCheckBox, "Make your password visible or unvisible.");
                formToolTip.SetToolTip(languageComboBox, "Change your language.");
                formToolTip.SetToolTip(exitBtn, "Exit the application.");
            }
            else if(languageComboBox.SelectedItem.ToString()=="Bulgarian")
            {
                this.Text = "Електроният училищен дневник";
                languageLabel.Text = "Език";
                visiblepasswordCheckBox.Text = "Видимо";
                introductionLabel.Text = "Добре дошли в електрония училищен дневник";
                usernameLabel.Text = "Име";
                passwordLabel.Text = "Парола";
                logInBtn.Text = "Влизане";
                registerBtn.Text = "Регистрация";
                exitBtn.Text = "Изход";
                formToolTip.SetToolTip(usernameTextBox, "Напишете си първото име.");
                formToolTip.SetToolTip(passwordTextBox, "Напишете си паролата на акаунта.");
                formToolTip.SetToolTip(registerBtn, "Създайте нов акаунт.");
                formToolTip.SetToolTip(logInBtn, "");
                formToolTip.SetToolTip(visiblepasswordCheckBox, "Влезте в съществуващ вече акаунт.");
                formToolTip.SetToolTip(languageComboBox, "Сменете езика.");
                formToolTip.SetToolTip(exitBtn, "Излезте от приложението.");
            }
        }

        private void E_Journal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog==DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if(dialog==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
