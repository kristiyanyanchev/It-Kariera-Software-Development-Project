using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using Data.Repositories;
using System.Threading;

namespace WinFormsView.UpdateControls
{
    public partial class ChangePasswordControl : UserControl
    {
        public ChangePasswordControl(string language, Student student)
        {
            if (language == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();

            studentinfo = student;
            isstudent = true;
        }

        public ChangePasswordControl(string language, Teacher teacher)
        {
            if (language == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();

            teacherinfo = teacher;
            isteacher = true;
        }

        public ChangePasswordControl(string language, Parent parent)
        {
            if (language == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();

            parentinfo = parent;
            isparent = true;
        }

        private StudentsRepository studentrepo = new StudentsRepository();
        private ParentsRepository parentrepo = new ParentsRepository();
        private TeachersRepository teacherrepo = new TeachersRepository();

        private Student studentinfo;
        private Teacher teacherinfo;
        private Parent parentinfo;

        private bool isstudent;
        private bool isparent;
        private bool isteacher;

        private bool Validate()
        {
            if(oldPasswordTextBox.Text!=null && newPasswordTextBox.Text!=null && confirmNewPasswordTextBox.Text!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleNewCheckBox.Checked)
            {
                newPasswordTextBox.PasswordChar = '\0';
                confirmNewPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                newPasswordTextBox.PasswordChar = '*';
                confirmNewPasswordTextBox.PasswordChar = '*';
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (isstudent)
                {
                    newPasswordTextBox.PasswordChar = '\0';
                    studentinfo = studentrepo.GetById(studentinfo.Id);
                    studentinfo.Password = newPasswordTextBox.Text;
                    studentrepo.Edit(studentinfo);
                    if(visibleNewCheckBox.Checked==false)
                    {
                        newPasswordTextBox.PasswordChar = '*';
                    }
                }
                else if (isteacher)
                {
                    newPasswordTextBox.PasswordChar = '\0';
                    teacherinfo.Password = newPasswordTextBox.Text;
                    teacherrepo.Edit(teacherinfo);
                    if (visibleNewCheckBox.Checked == false)
                    {
                        newPasswordTextBox.PasswordChar = '*';
                    }
                }
                else if (isparent)
                {
                    newPasswordTextBox.PasswordChar = '\0';
                    parentinfo.Password = newPasswordTextBox.Text;
                    parentrepo.Edit(parentinfo);
                    if (visibleNewCheckBox.Checked == false)
                    {
                        newPasswordTextBox.PasswordChar = '*';
                    }
                }
                MessageBox.Show("Your password is changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visibleOldPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleNewCheckBox.Checked)
            {
                oldPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                oldPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
