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
using Controller;
using Data.Repositories;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        public LogInForm(string language)
        {
            if(language=="Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
        }

        private bool Validation()
        {
            if (passwordTextBox.Text != null && usernameTextBox.Text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetLanguage()
        {
            if(languageLabel.Text=="Language")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm(GetLanguage());
            registration.ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

            if(Validate())
            {
                TeachersRepository teacherRepository = new TeachersRepository();
                StudentsRepository studentRepository = new StudentsRepository();
                ParentsRepository parentRepository = new ParentsRepository();

                if(teacherRepository.List().Select(x=>x.Username).Contains(usernameTextBox.Text) && teacherRepository.List().Single(x => x.Username == usernameTextBox.Text).Password == passwordTextBox.Text)
                {
                    var teacher = teacherRepository.List().Single(x => x.Username == usernameTextBox.Text);
                    var teacherForm = new TeacherMainForm(teacher);
                    teacherForm.ShowDialog();
                }
                else if(studentRepository.List().Select(x=>x.Username).Contains(usernameTextBox.Text) && studentRepository.List().Single(x => x.Username == usernameTextBox.Text).Password == passwordTextBox.Text)
                {
                    var student = studentRepository.List().Single(x => x.Username == usernameTextBox.Text);
                    var studentForm = new StudentMainForm(student);
                    studentForm.ShowDialog();
                }
                else if(parentRepository.List().Select(x=>x.Username).Contains(usernameTextBox.Text) && parentRepository.List().Single(x => x.Username == usernameTextBox.Text).Password == passwordTextBox.Text)
                {
                    var parent = parentRepository.List().Single(x => x.Username == usernameTextBox.Text);
                    var parentForm = new ParentForm(parent);
                    parentForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Passowrd! ");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if(GetLanguage()=="English")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Наистина ли искате да излезете", "Въпрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
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

        //Смяна на езика
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
             * стар начин
            if(languageComboBox.SelectedItem.ToString()=="English")
            {
                this.Text = "School E-journal";
                languageLabel.Text = "Language";
                visiblepasswordCheckBox.Text = "Visible";
                introductionLabel.Text = "Welcome to the school E-Journal";
                nameLabel.Text = "Username";
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
                nameLabel.Text = "Име";
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
            }*/
        }

        private void E_Journal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GetLanguage() == "English")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Наистина ли искате да излезете", "Въпрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
