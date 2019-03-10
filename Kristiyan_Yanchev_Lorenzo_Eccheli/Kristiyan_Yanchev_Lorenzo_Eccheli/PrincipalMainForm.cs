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
    public partial class PrincipalMainForm : Form
    {
        public PrincipalMainForm()
        {
            InitializeComponent();
        }

        private string language;

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepassword = new ChangePasswordForm();
            changepassword.ShowDialog();
        }

        private void bonusesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalBonusesForm principalbonus = new PrincipalBonusesForm();
            principalbonus.ShowDialog();
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            language = languageComboBox.SelectedItem.ToString();
            this.Hide();
            PrincipalRemoveStudentForm principalremovestudent = new PrincipalRemoveStudentForm(language);
            principalremovestudent.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            TeacherAddStudentForm teacheradd = new TeacherAddStudentForm();
            teacheradd.ShowDialog();
        }

        private void viewStudentButton_Click(object sender, EventArgs e)
        {
            TeacherViewStudentsForm teacherview = new TeacherViewStudentsForm();
            teacherview.ShowDialog();
        }

        private void sickLeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalViewLeavesForm viewleaves = new PrincipalViewLeavesForm();
            viewleaves.ShowDialog();
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalSubjectsForm prinicpalsubject = new PrincipalSubjectsForm();
            prinicpalsubject.ShowDialog();
        }

        private void principalViewTeacherForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalViewTeachersForm teachers = new PrincipalViewTeachersForm();
            teachers.ShowDialog();
        }

        private void annnualLeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalViewLeavesForm viewleaves = new PrincipalViewLeavesForm();
            viewleaves.ShowDialog();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalTeachersForm teachers = new PrincipalTeachersForm();
            teachers.ShowDialog();
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            language = languageComboBox.SelectedItem.ToString();
            TeacherGradesForm teachergrade = new TeacherGradesForm(language);
            teachergrade.ShowDialog();
        }

        private void absencesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherAbsencesForm absences = new TeacherAbsencesForm();
            absences.ShowDialog();
        }

        private void PrincipalMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(languageComboBox.SelectedItem.ToString()=="Bulgarian")
            {
                introductionLabel.Text = "Добре дошли в електронния дневник";
                gradesButton.Text = "Оценки";
                addStudentButton.Text = "Добави Ученик";
                viewStudentButton.Text = "Виж Ученик";
                removeStudentButton.Text = "Премахни Ученик";
                viewteacherButton.Text = "Виж Учител";
                teachersButton.Text = "Учители";
                bonusesButton.Text = "Бонуси";
                sickLeaveButton.Text = "Болнични";
                absencesButton.Text = "Отсъствия";
                changePasswordButton.Text = "Смяна На Паролата";
                editInformationButton.Text = "Промяна На Информацията";
                annnualLeaveButton.Text = "Годишен Отпуск";
                subjectsButton.Text = "Предмети";
                languageLabel.Text = "Език";
                exitButton.Text = "Изход";
            }
            else
            {
                introductionLabel.Text = "Welcome to e-journal";
                gradesButton.Text = "Grades";
                addStudentButton.Text = "Add Student";
                viewStudentButton.Text = "View Student";
                removeStudentButton.Text = "Remove Student";
                viewteacherButton.Text = "View Teacher";
                teachersButton.Text = "Teachers";
                bonusesButton.Text = "Bounuses";
                sickLeaveButton.Text = "Sick Leave";
                absencesButton.Text = "Absences";
                changePasswordButton.Text = "Change Password";
                editInformationButton.Text = "Edit Information";
                annnualLeaveButton.Text = "Annual Leave";
                subjectsButton.Text = "Subjects";
                languageLabel.Text = "Language";
                exitButton.Text = "Exit";
            }
        }
    }
}
