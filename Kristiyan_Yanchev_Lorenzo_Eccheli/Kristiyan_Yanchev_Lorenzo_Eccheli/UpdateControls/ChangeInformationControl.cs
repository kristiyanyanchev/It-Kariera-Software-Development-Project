using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Data.Models;
using Data.Repositories;

namespace WinFormsView.UpdateControls
{
    public partial class ChangeInformationControl : UserControl
    {
        public ChangeInformationControl(string language,Student student)
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

            studentinfo = student;
            isstudent = true;
        }

        public ChangeInformationControl(string language,Teacher teacher)
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

        public ChangeInformationControl(string language,Parent parent)
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

        private bool Validation()
        {
            if (emailTextBox.Text != null && emailTextBox.Text.Contains("@") || (phoneNumberTextBox.Text != null &&
                phoneNumberTextBox.Text.Length == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                if(isstudent)
                {
                    studentinfo.PhoneNumber = phoneNumberTextBox.Text;
                    studentinfo.Email = emailTextBox.Text;
                    studentrepo.Edit(studentinfo);
                }
                else if(isteacher)
                {
                    teacherinfo.PhoneNumber = phoneNumberTextBox.Text;
                    teacherinfo.Email = emailTextBox.Text;
                    teacherrepo.Edit(teacherinfo);
                }
                else if(isparent)
                {
                    parentinfo.PhoneNumber = phoneNumberTextBox.Text;
                    parentinfo.Email = emailTextBox.Text;
                    parentrepo.Edit(parentinfo);
                }

                MessageBox.Show("Changes are made", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
