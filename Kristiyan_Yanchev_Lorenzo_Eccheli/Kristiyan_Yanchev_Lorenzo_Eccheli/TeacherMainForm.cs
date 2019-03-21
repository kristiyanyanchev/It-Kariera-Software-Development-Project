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
using Data.Models;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class TeacherMainForm : Form
    {
        public Teacher Teacher { get; set; }
        public TeacherMainForm(Teacher teacher)
        {
            Teacher = teacher;
            InitializeComponent();
        }

        private string language;

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
            
        }

        private void viewstudentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherViewStudentsForm teacerview = new TeacherViewStudentsForm();
            teacerview.ShowDialog();
        }

        private void addgradeButton_Click(object sender, EventArgs e)
        {
            language = languageComboBox.SelectedItem.ToString();
            TeacherGradesForm teachergrade = new TeacherGradesForm(language);
            teachergrade.ShowDialog();
        }

        private void addstudentButton_Click(object sender, EventArgs e)
        {
           //
        }

        private void absensesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherAbsencesForm teacherabsenses = new TeacherAbsencesForm();
            teacherabsenses.ShowDialog();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepassword = new ChangePasswordForm();
            changepassword.ShowDialog();
        }

        private void changeinformationButton_Click(object sender, EventArgs e)
        {
            ChangeInformationForm changeinformation = new ChangeInformationForm();
            changeinformation.ShowDialog();
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
            if(languageComboBox.SelectedItem.ToString()=="English")
            {
                introductionLabel.Text = "Welcome to E-journal ,Teacher";
                languageLabel.Text = "Language";
                viewstudentsButton.Text = "View Students";
                addgradeButton.Text = "Add Grade";
                addstudentButton.Text = "Add Student";
                absensesButton.Text = "Absenses";
                changePasswordButton.Text = "Change Password";
                changeinformationButton.Text = "Change Information";
                exitButton.Text = "Exit";
            }
            else
            {
                introductionLabel.Text = "Добре дошли в електронния дневник";
                languageLabel.Text = "Език";
                viewstudentsButton.Text = "Виж ученици";
                addgradeButton.Text = "Добави оценка";
                addstudentButton.Text = "Добави ученик";
                absensesButton.Text = "Отсъствия";
                changePasswordButton.Text = "Смени паролата";
                changeinformationButton.Text = "Смени информация";
                exitButton.Text = "Изход";
            }
            */
        }

        private void TeacherMainForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
