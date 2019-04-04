using Controller;
using Controller.RegistrationClasses;
using Controller.ValidationClasses;
using Data.Models;
using Data.Repositories;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WinFormsView;


namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(string language)
        {
            if(language=="English")
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
            if (roleComboBox.SelectedItem.ToString() == "Teacher" ||
                roleComboBox.SelectedItem.ToString() == "Учител")
            {
                if (usernameTextBox.Text != null && lastNameTextBox.Text != null &&
               passwordTextBox.Text != null && emailTextBox.Text != null &&
               firstNameTextBox.Text != null &&
               addressTextBox.Text != null && phoneNumberTextBox.Text != null &&
               roleComboBox.SelectedItem != null && double.TryParse(phoneNumberTextBox.Text, out double a) &&
               classnameTextBox.Text != null && subjectTextBox.Text != null && positionTextBox.Text != null &&
               classnameTextBox.Text != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (roleComboBox.SelectedItem.ToString() == "Student" ||
                roleComboBox.SelectedItem.ToString() == "Ученик")
            {
                if (usernameTextBox.Text != null && lastNameTextBox.Text != null &&
               passwordTextBox.Text != null && emailTextBox.Text != null &&
               firstNameTextBox.Text != null &&
               addressTextBox.Text != null && phoneNumberTextBox.Text != null &&
               roleComboBox.SelectedItem != null && double.TryParse(phoneNumberTextBox.Text, out double a) &&
               classnameTextBox.Text != null && ucnTextBox.Text != null && birthdatePicker.Text != DateTime.Today.ToString())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(roleComboBox.SelectedItem.ToString()=="Parent" ||
                roleComboBox.SelectedItem.ToString() == "Родител")
            {
                if (usernameTextBox.Text != null && lastNameTextBox.Text != null &&
               passwordTextBox.Text != null && emailTextBox.Text != null &&
               firstNameTextBox.Text != null &&
               addressTextBox.Text != null && phoneNumberTextBox.Text != null &&
               roleComboBox.SelectedItem != null && double.TryParse(phoneNumberTextBox.Text, out double a) &&
               usernameOfChildTextBox.Text != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private string GetLanguage()
        {
            if(usernameLabel.Text=="Username")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (GetLanguage() == "Bulgarian")
            {
                DialogResult dialog = MessageBox.Show("Наистина ли искате да излезете", "Въпрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            
            if (ValidateData())
            {
                if(roleComboBox.SelectedItem.ToString()=="Student" ||
                    roleComboBox.SelectedItem.ToString()=="Ученик")
                {
                    var studentDto = new StudentDataTransferObject(usernameTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text,
                        passwordTextBox.Text, emailTextBox.Text, addressTextBox.Text, phoneNumberTextBox.Text, validationCodeTextBox.Text, 
                        classnameTextBox.Text,ucnTextBox.Text,birthdatePicker.Value);

                    var studentValidator = new StudentValidator();
                    

                    if (studentValidator.ValidateStudent(studentDto) == "Successful Registration! ")
                    {

                        var student = new StudentRegistration().Register(studentDto);

                        this.Hide();
                        StudentMainForm studentform = new StudentMainForm(GetLanguage(),student);
                        studentform.ShowDialog();
                    }
                    MessageBox.Show(studentValidator.ValidateStudent(studentDto));
                }
                else if(roleComboBox.SelectedItem.ToString() == "Teacher" ||
                    roleComboBox.SelectedItem.ToString()=="Учител")
                {
                    var teacherDto = new TeacherDataTransferObject(firstNameTextBox.Text, lastNameTextBox.Text,
                        subjectTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text, positionTextBox.Text,
                        usernameTextBox.Text, passwordTextBox.Text, validationCodeTextBox.Text, classnameTextBox.Text, addressTextBox.Text);

                    var teacherValidator = new TeacherValidator();
                  

                    if (teacherValidator.ValidateTeacher(teacherDto) == "Successful Registration! ")
                    {

                        var teacher = new TeacherRegistration().Register(teacherDto);

                        this.Hide();
                        TeacherMainForm teacherform = new TeacherMainForm(GetLanguage(),teacher);
                        teacherform.ShowDialog();
                    }
                    MessageBox.Show(teacherValidator.ValidateTeacher(teacherDto));
                    
                }
                else if(roleComboBox.SelectedItem.ToString() == "Parent" ||
                    roleComboBox.SelectedItem.ToString()=="Родител")
                {
                    var parentDto = new ParentDataTransferObject(usernameTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text,
                        passwordTextBox.Text, emailTextBox.Text, addressTextBox.Text, phoneNumberTextBox.Text, validationCodeTextBox.Text,
                        usernameOfChildTextBox.Text);

                    var parentValidator = new ParentValidator();

                    if (parentValidator.ValidateParent(parentDto) == "Registration Successful! ")
                    {

                        var parent = new ParentRegistration().Register(parentDto);

                        this.Hide();
                        ParentForm parentform = new ParentForm(GetLanguage(),parent);
                        parentform.ShowDialog();
                    }
                    MessageBox.Show(parentValidator.ValidateParent(parentDto));
                }
                
            }
            else
            {
                if (GetLanguage() == "Bulgarian")
                {
                    MessageBox.Show("Грешни данни", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Invalid data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (GetLanguage() == "Bulgarian")
            {
                DialogResult dialog = MessageBox.Show("Наистина ли искате да излезете", "Въпрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    Application.ExitThread();
                }
                else if(dialog==DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    Application.ExitThread();
                }
                else if(dialog==DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Makeinvisible()
        {
            usernameOfChildLabel.Visible = false;
            usernameOfChildTextBox.Visible = false;
            ucnLabel.Visible = false;
            ucnTextBox.Visible = false;
            birthdayLabel.Visible = false;
            birthdatePicker.Visible = false;
            classnameLabel.Visible = false;
            classnameTextBox.Visible = false;
            subjectLabel.Visible = false;
            subjectTextBox.Visible = false;
            positionLabel.Visible = false;
            positionTextBox.Visible = false;

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Makeinvisible();
            if(roleComboBox.SelectedItem.ToString()=="Student" ||
                roleComboBox.SelectedItem.ToString() == "Ученик")
            {
                ucnLabel.Visible = true;
                ucnTextBox.Visible = true;
                birthdayLabel.Visible = true;
                birthdatePicker.Visible = true;
                classnameLabel.Visible = true;
                classnameTextBox.Visible = true;
            }
            else if(roleComboBox.SelectedItem.ToString()=="Parent" ||
                roleComboBox.SelectedItem.ToString() == "Родител")
            {
                usernameOfChildLabel.Visible = true;
                usernameOfChildTextBox.Visible = true;
            }
            else if(roleComboBox.SelectedItem.ToString() == "Teacher" ||
                roleComboBox.SelectedItem.ToString() == "Учител")
            {
                classnameLabel.Visible = true;
                classnameTextBox.Visible = true;
                subjectLabel.Visible = true;
                subjectTextBox.Visible = true;
                positionLabel.Visible = true;
                positionTextBox.Visible = true;
            }
            else
            {
                Makeinvisible();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm login = new LogInForm(GetLanguage());
            login.ShowDialog();
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
