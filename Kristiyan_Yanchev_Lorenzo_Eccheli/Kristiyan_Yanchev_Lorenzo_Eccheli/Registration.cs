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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private string nextformlanguage;

        public Registration(string language)
        {
            if (language == "Bulgarian")
            {
                nextformlanguage = language;
                InitializeComponent();
                introductionLabel.Text = "Регистрация в електронния училищен дневник";
                partoneLabel.Text = "Част 1";
                firstNameLabel.Text = "Име";
                passwordLabel.Text = "Парола";
                visibleCheckBox.Text = "Видимост";
                emailLabel.Text = "Емайл";
                addressLabel.Text = "Адрес";
                phoneLabel.Text = "Телефонен номер";
                lastNameLabel.Text = "Фамилия";
                roleLabel.Text = "Длъжност";
                nextPageButton.Text = "Напред";
                exitButton.Text = "Изход";
                formToolTip.SetToolTip(firstNameTextBox, "Въведете първото си име.");
                formToolTip.SetToolTip(lastNameTextBox, "Въведете фамилията си.");
                formToolTip.SetToolTip(passwordTextBox, "Създайте си парола.");
                formToolTip.SetToolTip(visibleCheckBox, "Направете паролата видима или невидима.");
                formToolTip.SetToolTip(roleComboBox,"Изберете си длъжност.");
                formToolTip.SetToolTip(emailTextBox,"Въведете си имайла.");
                formToolTip.SetToolTip(addressTextBox,"Напишете си адреса.");
                formToolTip.SetToolTip(phoneNumberTextBox, "Сложете си телефонния номер.");
                formToolTip.SetToolTip(nextPageButton, "Продължете с регистрацията.");
                formToolTip.SetToolTip(exitButton, "Излезте от прилойението.");
            }
            else if(language=="English")
            {
                nextformlanguage = language;
                InitializeComponent();
                introductionLabel.Text = "Registration  to School E-Journal";
                partoneLabel.Text = "Part 1";
                firstNameLabel.Text = "Name";
                passwordLabel.Text = "Password";
                visibleCheckBox.Text = "Visible";
                emailLabel.Text = "E-mail";
                addressLabel.Text = "Address";
                phoneLabel.Text = "Phone number";
                lastNameLabel.Text = "Family";
                roleLabel.Text = "Role";
                nextPageButton.Text = "Next";
                exitButton.Text = "Exit";
                formToolTip.SetToolTip(firstNameTextBox, "Enter your first name.");
                formToolTip.SetToolTip(lastNameTextBox, "Enter your family.");
                formToolTip.SetToolTip(passwordTextBox, "Create new password.");
                formToolTip.SetToolTip(visibleCheckBox, "Make your password visible or unvisible.");
                formToolTip.SetToolTip(roleComboBox, "Choose your role.");
                formToolTip.SetToolTip(emailTextBox, "Enter your e-mail address.");
                formToolTip.SetToolTip(addressTextBox, "Enter your home address.");
                formToolTip.SetToolTip(phoneNumberTextBox, "Enter your phone number .");
                formToolTip.SetToolTip(nextPageButton, "Continue with the registration.");
                formToolTip.SetToolTip(exitButton, "Exit the application.");
            }
        }

        private bool ValidateData()
        {
            if(firstNameTextBox.Text!=null && lastNameTextBox.Text!=null && 
               passwordTextBox.Text!=null && emailTextBox.Text!=null && 
               addressTextBox.Text!=null && phoneNumberTextBox.Text!=null && 
               roleComboBox.SelectedItem!=null && double.TryParse(phoneNumberTextBox.Text,out double a))
            {
                return true;
            }
            return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                this.Hide();
                StudentRegistrationForm studentregistration = new StudentRegistrationForm(nextformlanguage);
                studentregistration.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormCLosing(object sender, FormClosingEventArgs e)
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
