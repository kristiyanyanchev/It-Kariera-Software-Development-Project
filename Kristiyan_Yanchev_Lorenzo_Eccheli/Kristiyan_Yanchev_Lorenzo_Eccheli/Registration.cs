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
                firstNameLabel.Text = "Име";
                passwordLabel.Text = "Парола";
                visibleCheckBox.Text = "Видимост";
                emailLabel.Text = "Емайл";
                addressLabel.Text = "Адрес";
                phoneLabel.Text = "Телефонен номер";
                lastNameLabel.Text = "Фамилия";
                roleLabel.Text = "Длъжност";
                registrationButton.Text = "Напред";
                exitButton.Text = "Изход";
                validationCodeLabel.Text = "*Код";
                formToolTip.SetToolTip(firstNameTextBox, "Въведете първото си име.");
                formToolTip.SetToolTip(lastNameTextBox, "Въведете фамилията си.");
                formToolTip.SetToolTip(passwordTextBox, "Създайте си парола.");
                formToolTip.SetToolTip(visibleCheckBox, "Направете паролата видима или невидима.");
                formToolTip.SetToolTip(roleComboBox,"Изберете си длъжност.");
                formToolTip.SetToolTip(emailTextBox,"Въведете си имайла.");
                formToolTip.SetToolTip(addressTextBox,"Напишете си адреса.");
                formToolTip.SetToolTip(phoneNumberTextBox, "Сложете си телефонния номер.");
                formToolTip.SetToolTip(registrationButton, "Акаунтът ви ще е регистриран.");
                formToolTip.SetToolTip(exitButton, "Излезте от прилойението.");
                formToolTip.SetToolTip(validationCodeLabel, "Задължителен код даден от училището.");
            }
            else if(language=="English")
            {
                nextformlanguage = language;
                InitializeComponent();
                introductionLabel.Text = "Registration  to School E-Journal";
                firstNameLabel.Text = "Name";
                passwordLabel.Text = "Password";
                visibleCheckBox.Text = "Visible";
                emailLabel.Text = "E-mail";
                addressLabel.Text = "Address";
                phoneLabel.Text = "Phone number";
                lastNameLabel.Text = "Family";
                roleLabel.Text = "Role";
                registrationButton.Text = "Next";
                exitButton.Text = "Exit";
                validationCodeLabel.Text = "*Validation Code";
                formToolTip.SetToolTip(firstNameTextBox, "Enter your first name.");
                formToolTip.SetToolTip(lastNameTextBox, "Enter your family.");
                formToolTip.SetToolTip(passwordTextBox, "Create new password.");
                formToolTip.SetToolTip(visibleCheckBox, "Make your password visible or unvisible.");
                formToolTip.SetToolTip(roleComboBox, "Choose your role.");
                formToolTip.SetToolTip(emailTextBox, "Enter your e-mail address.");
                formToolTip.SetToolTip(addressTextBox, "Enter your home address.");
                formToolTip.SetToolTip(phoneNumberTextBox, "Enter your phone number .");
                formToolTip.SetToolTip(registrationButton, "Your account will be registered.");
                formToolTip.SetToolTip(exitButton, "Exit the application.");
                formToolTip.SetToolTip(validationCodeLabel, "Required code given by the school.");
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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

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

        private void Makeinvisible()
        {
            nameofchildLabel.Visible = false;
            nameofchildTextBox.Visible = false;
            egnLabel.Visible = false;
            egnTextBox.Visible = false;
            birthdayLabel.Visible = false;
            birthdatePicker.Visible = false;
            scholarshipLabel.Visible = false;
            scholarshipTextBox.Visible = false;
            classnameLabel.Visible = false;
            classnameTextBox.Visible = false;
            subjectLabel.Visible = false;
            subjectTextBox.Visible = false;

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Makeinvisible();
            if(roleComboBox.SelectedItem.ToString()=="Student")
            {
                if (firstNameLabel.Text == "Name")
                {
                    egnLabel.Visible = true;
                    egnTextBox.Visible = true;
                    birthdayLabel.Visible = true;
                    birthdatePicker.Visible = true;
                    scholarshipLabel.Visible = true;
                    scholarshipTextBox.Visible = true;
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    egnLabel.Text = "EGN";
                    birthdayLabel.Text = "Date of birth";
                    scholarshipLabel.Text = "Scholarship";
                    classnameLabel.Text = "Class";
                }
                else
                {
                    egnLabel.Visible = true;
                    egnTextBox.Visible = true;
                    birthdayLabel.Visible = true;
                    birthdatePicker.Visible = true;
                    scholarshipLabel.Visible = true;
                    scholarshipTextBox.Visible = true;
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    egnLabel.Text = "ЕГН";
                    birthdayLabel.Text = "Дата на раждане";
                    scholarshipLabel.Text = "Стипендия";
                    classnameLabel.Text = "Клас";
                }
            }
            else if(roleComboBox.SelectedItem.ToString()=="Parent")
            {
                if(firstNameLabel.Text=="Name")
                {
                    nameofchildLabel.Visible = true;
                    nameofchildTextBox.Visible = true;
                    nameofchildLabel.Text = "Name of child";
                }
                else
                {
                    nameofchildLabel.Visible = true;
                    nameofchildTextBox.Visible = true;
                    nameofchildLabel.Text = "Име на детето";
                }
            }
            else if(roleComboBox.SelectedItem.ToString() == "Teacher")
            {
                if (firstNameLabel.Text == "Name")
                {
                    subjectLabel.Visible = true;
                    subjectTextBox.Visible = true;
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    subjectLabel.Text = "Subject";
                    classnameLabel.Text = "Class";

                }
                else
                {
                    subjectLabel.Visible = true;
                    subjectTextBox.Visible = true;
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    subjectLabel.Text = "Предмет";
                    classnameLabel.Text = "Клас";
                }
            }
        }
    }
}
