using Controller;
using Controller.ValidationClasses;
using Data.Models;
using Data.Repositories;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Controller;


namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

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
            /*
            if (language == "Bulgarian" || language=="Български")
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
                formToolTip.SetToolTip(firstNameTextBox, "Въведете първото си име.");
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
            else 
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
            }*/
        }

        private bool ValidateData()
        {
            if(roleComboBox.SelectedItem.ToString()=="Teacher")
            {
                if (usernameTextBox.Text != null && lastNameTextBox.Text != null &&
               passwordTextBox.Text != null && emailTextBox.Text != null &&
               firstNameTextBox.Text != null &&
               addressTextBox.Text != null && phoneNumberTextBox.Text != null &&
               roleComboBox.SelectedItem != null && double.TryParse(phoneNumberTextBox.Text, out double a) &&
               classnameTextBox.Text!=null && subjectTextBox.Text!=null && positionTextBox.Text!=null &&
               classnameTextBox.Text!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(roleComboBox.SelectedItem.ToString()=="Student")
            {
                if (usernameTextBox.Text != null && lastNameTextBox.Text != null &&
               passwordTextBox.Text != null && emailTextBox.Text != null &&
               firstNameTextBox.Text != null &&
               addressTextBox.Text != null && phoneNumberTextBox.Text != null &&
               roleComboBox.SelectedItem != null && double.TryParse(phoneNumberTextBox.Text, out double a)&&
               classnameTextBox.Text!=null && ucnTextBox.Text!=null && birthdatePicker.Text!=DateTime.Today.ToString())
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
                if (usernameTextBox.Text != null && lastNameTextBox.Text != null &&
               passwordTextBox.Text != null && emailTextBox.Text != null &&
               firstNameTextBox.Text != null &&
               addressTextBox.Text != null && phoneNumberTextBox.Text != null &&
               roleComboBox.SelectedItem != null && double.TryParse(phoneNumberTextBox.Text, out double a)&&
               nameofchildTextBox.Text!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
            //if(firstNameTextBox.Text!=null && lastNameTextBox.Text!=null && 
            //   passwordTextBox.Text!=null && emailTextBox.Text!=null && 
            //   nameTextBox.Text!=null &&
            //   addressTextBox.Text!=null && phoneNumberTextBox.Text!=null && 
            //   roleComboBox.SelectedItem!=null && double.TryParse(phoneNumberTextBox.Text,out double a))
            //{
            //    return true;
            //}
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

                    var classes = new ClassesRepository();
                    var studentsRepo = new StudentsRepository();
                    var studentValidator = new StudentValidator();

                    if (studentValidator.ValidateStudent(studentDto) == "Successful Registration! ")
                    { 
                        var student = new Student(studentDto.FirstName, studentDto.LastName, studentDto.BirthDate,
                            studentDto.Address, studentDto.Ucn, studentDto.PhoneNumber, studentDto.Email, studentDto.Username, studentDto.Password,
                            studentDto.ValidationCode, classes.List().Single(x => x.Name == studentDto.Class));
                        
                        studentsRepo.Add(student);

                        
                        this.Hide();
                        StudentMainForm studentform = new StudentMainForm();
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
                    var teacherRepo = new TeachersRepository();

                    if (teacherValidator.ValidateTeacher(teacherDto) == "Successful Registration! ")
                    {
                        var teacher = new Teacher(teacherDto.FirstName, teacherDto.LastName, teacherDto.Subject, teacherDto.PhoneNumber,
                            teacherDto.Email, teacherDto.Position, teacherDto.Username, teacherDto.Password, teacherDto.ValidationCode, teacherDto.Address);

                        if (teacherDto.Class == "none")
                        {
                            teacher.Class = null;
                        }
                        else
                        {
                            teacher.Class = new ClassesRepository().List().Single(x => x.Name == teacherDto.Class);
                        }

                        teacherRepo.Add(teacher);

                        
                        this.Hide();
                        TeacherMainForm teacherform = new TeacherMainForm();
                        teacherform.ShowDialog();
                    }
                    MessageBox.Show(teacherValidator.ValidateTeacher(teacherDto));
                    
                }
                else if(roleComboBox.SelectedItem.ToString() == "Parent" ||
                    roleComboBox.SelectedItem.ToString()=="Родител")
                {
                    this.Hide();
                    ParentForm parentform = new ParentForm(GetLanguage());
                    parentform.ShowDialog();
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
                nameofchildLabel.Visible = true;
                nameofchildTextBox.Visible = true;
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
            
            /*
            if (languageComboBox.SelectedItem.ToString() == "Bulgarian")
            {
                nextformlanguage = "Bulgarian";
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
                formToolTip.SetToolTip(firstNameTextBox, "Въведете първото си име.");
                formToolTip.SetToolTip(lastNameTextBox, "Въведете фамилията си.");
                formToolTip.SetToolTip(passwordTextBox, "Създайте си парола.");
                formToolTip.SetToolTip(visibleCheckBox, "Направете паролата видима или невидима.");
                formToolTip.SetToolTip(roleComboBox, "Изберете си длъжност.");
                formToolTip.SetToolTip(emailTextBox, "Въведете си имайла.");
                formToolTip.SetToolTip(addressTextBox, "Напишете си адреса.");
                formToolTip.SetToolTip(phoneNumberTextBox, "Сложете си телефонния номер.");
                formToolTip.SetToolTip(registrationButton, "Акаунтът ви ще е регистриран.");
                formToolTip.SetToolTip(exitButton, "Излезте от приложението.");
                formToolTip.SetToolTip(validationCodeLabel, "Задължителен код даден от училището.");
            }
            else
            {
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
            */
        }
    }
           
}
