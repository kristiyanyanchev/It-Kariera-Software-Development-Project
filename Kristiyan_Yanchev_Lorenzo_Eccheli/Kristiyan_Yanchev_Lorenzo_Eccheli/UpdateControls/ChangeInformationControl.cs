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
using System.Threading;
using Data.Repositories;
using Controller.ValidationClasses.Email;
using Controller.ValidationClasses.PhoneNumber;

namespace WinFormsView.UpdateControls
{
    public partial class ChangeInformationControl : UserControl
    {
        private Teacher Teacher;
        private Parent Parent;
        private Student Student;
        private string Language;
        public ChangeInformationControl(Teacher teacher,string language)
        {
            
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
            Teacher = teacher;
            Language = language;
        }

        public ChangeInformationControl(Student student,string language)
        {
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
            Student = student;
            Language = language;
        }

        public ChangeInformationControl(Parent parent,string language)
        {
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
            Parent = parent;
            Language = language;
        }

        private void changeInfrormationButton_Click(object sender, EventArgs e)
        {
            var emailValidator = new DefaultEmailValidator();
            var phoneNumberValidator = new DefaultPhoneNumberValidator();
            if (emailValidator.Validate(emailTextBox.Text) && phoneNumberValidator.Validate(phoneNumberTextBox.Text))
            {
                if (Parent != null)
                {
                    Parent.Email = emailTextBox.Text;
                    Parent.PhoneNumber = phoneNumberTextBox.Text;
                    new ParentsRepository().Edit(Parent);
                }
                else if (Student != null)
                {
                    Student.Email = emailTextBox.Text;
                    Student.PhoneNumber = phoneNumberTextBox.Text;
                    new StudentsRepository().Edit(Student);
                }
                else//Teacher
                {
                    Teacher.Email = emailTextBox.Text;
                    Teacher.PhoneNumber = phoneNumberTextBox.Text;
                    new TeachersRepository().Edit(Teacher);
                }
            }
            else if (emailValidator.Validate(emailTextBox.Text))
            {
                if (Parent != null)
                {
                    Parent.Email = emailTextBox.Text;
                    new ParentsRepository().Edit(Parent);

                }
                else if (Student != null)
                {
                    Student.Email = emailTextBox.Text;
                    new StudentsRepository().Edit(Student);
                }
                else//Teacher
                {
                    Teacher.Email = emailTextBox.Text;
                    new TeachersRepository().Edit(Teacher);
                }
            }
            else if (phoneNumberValidator.Validate(phoneNumberTextBox.Text))
            {
                if (Parent != null)
                {
                    
                    Parent.PhoneNumber = phoneNumberTextBox.Text;
                    new ParentsRepository().Edit(Parent);
                }
                else if (Student != null)
                {
                    
                    Student.PhoneNumber = phoneNumberTextBox.Text;
                    new StudentsRepository().Edit(Student);
                }
                else//Teacher
                {
                    Teacher.PhoneNumber = phoneNumberTextBox.Text;
                    new TeachersRepository().Edit(Teacher);
                }
            }
            else
            {
                if (Language == "Bulgarian")
                {
                    MessageBox.Show("Моля въведете имейл и/или телефонен номер!");
                }
                else
                {
                    MessageBox.Show("Please Enter email and/or phone number!");
                }
               
            }

            
            
        }
    }
}
