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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void viewGradesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewGradesForm studentgrades = new StudentViewGradesForm();
            studentgrades.ShowDialog();
        }

        private void viewAbsencesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewAbsencesForm studentabsences = new StudentViewAbsencesForm();
            studentabsences.ShowDialog();
        }

        private void viewSubjectsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewSubjectsForm studentsubject = new StudentViewSubjectsForm();
            studentsubject.ShowDialog();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepassword = new ChangePasswordForm();
            changepassword.ShowDialog();
        }

        private void searchStudent_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void searchTeacher_Click(object sender, EventArgs e)
        {

        }

        private void viewScheduleButton_Click(object sender, EventArgs e)
        {
            
        }

        private void changeInformationButton_Click(object sender, EventArgs e)
        {
            ChangeInformationForm changeInformation = new ChangeInformationForm();
            changeInformation.ShowDialog();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(languageComboBox.SelectedIndex.ToString()=="Bulgarian")
            {
                introductionLabel.Text = "Добре дошли в електронния дневник";
                searchTeacher.Text = "Търси учител";
                searchStudent.Text = "Търси ученик";
                viewGradesButton.Text = "Оценки";
                viewSubjectsButton.Text = "Предмети";
                viewScheduleButton.Text = "Програма";
                viewAbsencesButton.Text = "Отсъствия";
                changePassword.Text = "Смени паролата";
                changeInformation.Text = "Смени информация";
                languageLabel.Text = "Език";
                exitButton.Text = "Изход";
            }
            else
            {
                introductionLabel.Text = "Welcome to E-journal , Student";
                searchTeacher.Text = "Search Teacher";
                searchStudent.Text = "Search Student";
                viewGradesButton.Text = "Grades";
                viewSubjectsButton.Text = "Subjects";
                viewScheduleButton.Text = "Schedule";
                viewAbsencesButton.Text = "Absence";
                changePassword.Text = "Change Password";
                changeInformation.Text = "Change Information";
                languageLabel.Text = "Language";
                exitButton.Text = "Exit";
            }
        }
    }
}
