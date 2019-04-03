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
using Data.Models;
using WinFormsView;

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

        private bool ValidateUsernameAndPassword()
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

            if(ValidateUsernameAndPassword())
            {
                TeachersRepository teacherRepository = new TeachersRepository();
                StudentsRepository studentRepository = new StudentsRepository();
                ParentsRepository parentRepository = new ParentsRepository();

                if(teacherRepository.List().Select(x=>x.Username).Contains(usernameTextBox.Text) && 
                    teacherRepository.List().Single(x => x.Username == usernameTextBox.Text).Password == passwordTextBox.Text)
                {
                    var teacher = teacherRepository.List().Single(x => x.Username == usernameTextBox.Text);
                    var teacherForm = new TeacherMainForm(GetLanguage(),teacher);
                    teacherForm.ShowDialog();
                }

                else if(studentRepository.List().Select(x=>x.Username).Contains(usernameTextBox.Text) && 
                    studentRepository.List().Single(x => x.Username == usernameTextBox.Text).Password == passwordTextBox.Text)
                {
                    var student = studentRepository.List().Single(x => x.Username == usernameTextBox.Text);
                    var studentForm = new StudentMainForm(GetLanguage(),student);
                    studentForm.ShowDialog();
                }

                else if(parentRepository.List().Select(x=>x.Username).Contains(usernameTextBox.Text) && 
                    parentRepository.List().Single(x => x.Username == usernameTextBox.Text).Password == passwordTextBox.Text)
                {
                    var parent = parentRepository.List().Single(x => x.Username == usernameTextBox.Text);
                    var parentForm = new ParentForm(GetLanguage(), parent);
                    parentForm.ShowDialog();
                }

                else if (GetLanguage() == "English")
                {
                    MessageBox.Show("You doesn't have account!Please register", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else 
                {
                    MessageBox.Show("Нямате акаунт!Моля регистрирайте се", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(GetLanguage() == "English")
            {
                MessageBox.Show("Invalid Username or Passowrd!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Грешно име или парола", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if(GetLanguage()=="English")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Наистина ли искате да излезете?", "Въпрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
        
        private void LogInForm_FormClosing(object sender, FormClosingEventArgs eventArgs)
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
                    eventArgs.Cancel = true;
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
                    eventArgs.Cancel = true;
                }
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            usernameLabel.BackColor = Color.Transparent;
            passwordLabel.BackColor = Color.Transparent;
            visiblepasswordCheckBox.BackColor = Color.Transparent;
            languageLabel.BackColor = Color.Transparent;
            logInBtn.BackColor = Color.Transparent;
            registerBtn.BackColor = Color.Transparent;
            exitBtn.BackColor = Color.Transparent;
        }
    }
}
