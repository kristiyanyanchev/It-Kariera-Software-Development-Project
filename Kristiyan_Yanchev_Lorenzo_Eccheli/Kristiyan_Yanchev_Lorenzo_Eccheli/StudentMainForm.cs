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
using WinFormsView.StudentControls;
using WinFormsView.UpdateControls;

namespace WinFormsView
{
    public partial class StudentMainForm : Form
    {
        public Student Student { get; set; }

        public StudentMainForm(Student student)
        {
            Student = student;
            InitializeComponent();
            StudentViewGradeContol studentcontrol = new StudentViewGradeContol();
            panelInformation.Controls.Add(studentcontrol);
        }

        public StudentMainForm(string language,Student student)
        {
            Student = student;
            if (language == "English")
            {

                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
            StudentControls.StudentViewGradeContol studentcontrol = new StudentControls.StudentViewGradeContol(GetLanguage(),student);
            panelInformation.Controls.Add(studentcontrol);
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

        private void closeButton_Click(object sender, EventArgs e)
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
            if (GetLanguage() == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
            StudentControls.StudentViewGradeContol studentsgrades = new StudentControls.StudentViewGradeContol(GetLanguage(),Student);
            panelInformation.Controls.Add(studentsgrades);
        }

        private void StudentMainForm_FormClosing(object sender, FormClosingEventArgs e)
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
            StudentViewGradeContol studentcontrol = new StudentViewGradeContol();
            panelInformation.Controls.Add(studentcontrol);
            
        }

        private void absencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            StudentViewAbsencesControl studentabsences = new StudentViewAbsencesControl();
            panelInformation.Controls.Add(studentabsences);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            ChangePasswordControl changepassword = new ChangePasswordControl();
            panelInformation.Controls.Add(changepassword);
        }

        private void changeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            ChangeInformationControl changeinformation = new ChangeInformationControl();
            panelInformation.Controls.Add(changeinformation);
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
