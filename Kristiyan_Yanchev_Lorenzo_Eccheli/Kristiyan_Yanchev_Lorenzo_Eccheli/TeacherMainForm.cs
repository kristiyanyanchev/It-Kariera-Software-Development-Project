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
using WinFormsView.TeacherControls;
using WinFormsView.UpdateControls;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class TeacherMainForm : Form
    {
        string Language;
        public TeacherMainForm(string language,Teacher teacher)
        {
            if (language == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            Teacher = teacher;
            Language = language;
            InitializeComponent();
            TeacherGradeControl teachergrade = new TeacherGradeControl(GetLanguage(),teacher);
            panelInformation.Controls.Add(teachergrade);
        }

        private Teacher Teacher;

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
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

            TeacherGradeControl teachergrade = new TeacherGradeControl(GetLanguage(), Teacher);
            panelInformation.Controls.Add(teachergrade);
            InitializeComponent();
            

          
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

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            TeacherGradeControl teachergrade = new TeacherGradeControl(GetLanguage(), Teacher);
            panelInformation.Controls.Add(teachergrade);
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            TeacherViewStudentControl teachersearchstudent = new TeacherViewStudentControl(GetLanguage());
            panelInformation.Controls.Add(teachersearchstudent);
        }

        private void absencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            TeacherAbsencesControl teacherabsences = new TeacherAbsencesControl(GetLanguage(),Teacher);
            panelInformation.Controls.Add(teacherabsences);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            ChangePasswordControl teacherchangepassword = new ChangePasswordControl(GetLanguage(), Teacher);
            panelInformation.Controls.Add(teacherchangepassword);
        }

        private void changeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            ChangeInformationControl teacherchangeinformation = new ChangeInformationControl(Teacher,GetLanguage());
            
            panelInformation.Controls.Add(teacherchangeinformation);
        }
    }
}
