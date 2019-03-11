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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private string nextformlanguage,username;

        public RegistrationForm(string language)
        {
            if (language == "Bulgarian")
            {
                nextformlanguage = language;
                InitializeComponent();
                introductionLabel.Text = "Регистрация в електронния училищен дневник";
                usernameLabel.Text = "Име";
                passwordLabel.Text = "Парола";
                visibleCheckBox.Text = "Видимост";
                emailLabel.Text = "Емайл";
                addressLabel.Text = "Адрес";
                phoneLabel.Text = "Телефонен номер";
                lastNameLabel.Text = "Фамилия";
                roleLabel.Text = "Длъжност";
                registrationButton.Text = "Регистрация";
                exitButton.Text = "Изход";
                validationCodeLabel.Text = "*Код";
                formToolTip.SetToolTip(usernameTextBox, "Въведете първото си име.");
                formToolTip.SetToolTip(lastNameTextBox, "Въведете фамилията си.");
                formToolTip.SetToolTip(passwordTextBox, "Създайте си парола.");
                formToolTip.SetToolTip(visibleCheckBox, "Направете паролата видима или невидима.");
                formToolTip.SetToolTip(roleComboBox,"Изберете си длъжност.");
                formToolTip.SetToolTip(emailTextBox,"Въведете си имайла.");
                formToolTip.SetToolTip(addressTextBox,"Напишете си адреса.");
                formToolTip.SetToolTip(phoneNumberTextBox, "Сложете си телефонния номер.");
                formToolTip.SetToolTip(registrationButton, "Акаунтът ви ще е регистриран.");
                formToolTip.SetToolTip(exitButton, "Излезте от приложението.");
                formToolTip.SetToolTip(validationCodeLabel, "Задължителен код даден от училището.");
            }
            else if(language=="English")
            {
                nextformlanguage = language;
                InitializeComponent();
                introductionLabel.Text = "Registration  to School E-Journal";
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                visibleCheckBox.Text = "Visible";
                emailLabel.Text = "E-mail";
                addressLabel.Text = "Address";
                phoneLabel.Text = "Phone number";
                lastNameLabel.Text = "Last Name";
                roleLabel.Text = "Role";
                registrationButton.Text = "Registration";
                exitButton.Text = "Exit";
                validationCodeLabel.Text = "*Validation Code";
                formToolTip.SetToolTip(usernameTextBox, "Enter your first name.");
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
            if(usernameTextBox.Text!=null && lastNameTextBox.Text!=null && 
               passwordTextBox.Text!=null && emailTextBox.Text!=null && 
               nameTextBox.Text!=null &&
               addressTextBox.Text!=null && phoneNumberTextBox.Text!=null && 
               roleComboBox.SelectedItem!=null && double.TryParse(phoneNumberTextBox.Text,out double a)&&
               phoneNumberTextBox.Text.Length==10)
            {
                if(roleComboBox.SelectedItem.ToString()=="Student" &&
                    classnameTextBox.Text!=null && ucnTextBox.Text!=null)
                {
                    return true;
                }
            
                else if(roleComboBox.SelectedItem.ToString() == "Teacher"&&
                        classnameTextBox.Text!=null)
                {
                    return true;
                }
                else if(roleComboBox.SelectedItem.ToString() == "Parent" &&
                    nameofchildTextBox.Text!=null)
                {
                    return true;
                }
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
                if(roleComboBox.SelectedItem.ToString()=="Student")
                {
                    this.Hide();
                    username = usernameTextBox.Text;
                    StudentMainForm studentform = new StudentMainForm(nextformlanguage,username);
                    studentform.ShowDialog();
                }
                else if(roleComboBox.SelectedItem.ToString() == "Teacher")
                {
                    this.Hide();
                    TeacherMainForm teacherform = new TeacherMainForm();
                    teacherform.ShowDialog();
                }
                else if(roleComboBox.SelectedItem.ToString() == "Parent")
                {
                    this.Hide();
                    ParentForm parentform = new ParentForm();
                    parentform.ShowDialog();

                }
                else
                {
                    this.Hide();
                    PrincipalMainForm principalform = new PrincipalMainForm();
                    principalform.ShowDialog();
                }
                
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
            ucnLabel.Visible = false;
            ucnTextBox.Visible = false;
            birthdayLabel.Visible = false;
            birthdatePicker.Visible = false;
            classnameLabel.Visible = false;
            classnameTextBox.Visible = false;

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Makeinvisible();
            if(roleComboBox.SelectedItem.ToString()=="Student")
            {
                if (usernameLabel.Text == "Username")
                {
                    ucnLabel.Visible = true;
                    ucnTextBox.Visible = true;
                    birthdayLabel.Visible = true;
                    birthdatePicker.Visible = true;
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    ucnLabel.Text = "UCN" ;
                    birthdayLabel.Text = "Date of birth";
                    classnameLabel.Text = "Class";
                }
                else
                {
                    ucnLabel.Visible = true;
                    ucnTextBox.Visible = true;
                    birthdayLabel.Visible = true;
                    birthdatePicker.Visible = true;
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    ucnLabel.Text = "ЕГН";
                    birthdayLabel.Text = "Дата на раждане";
                    classnameLabel.Text = "Клас";
                }
            }
            else if(roleComboBox.SelectedItem.ToString()=="Parent")
            {
                if(usernameLabel.Text== "Username")
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
                if (usernameLabel.Text == "Username")
                {
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    classnameLabel.Text = "Class";

                }
                else
                {
                    classnameLabel.Visible = true;
                    classnameTextBox.Visible = true;
                    classnameLabel.Text = "Клас";
                }
            }
            else
            {
                Makeinvisible();
            }
        }
    }
}
