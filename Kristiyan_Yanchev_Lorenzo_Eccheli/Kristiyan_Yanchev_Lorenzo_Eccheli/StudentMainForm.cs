﻿using System;
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

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
            StudentControls.StudentViewGradeContol studentcontrol = new StudentControls.StudentViewGradeContol();
            panelInformation.Controls.Add(studentcontrol);
        }

        public StudentMainForm(string language)
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
        }

        private string GetLanguage()
        {
            if(languageLabel.Text=="Language")
            {
                return "English";
            }
            else
            {
                return "BUlgarian";
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
            if (languageComboBox.SelectedItem.ToString() == "English" ||
                languageComboBox.SelectedItem.ToString() == "Английски")
            {
                StudentControls.StudentGradeStatisticControl studentsgrades = new StudentControls.StudentGradeStatisticControl(GetLanguage());
                panelInformation.Controls.Add(studentsgrades);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                StudentControls.StudentGradeStatisticControl studentsgrades = new StudentControls.StudentGradeStatisticControl(GetLanguage());
                panelInformation.Controls.Add(studentsgrades);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
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
            StudentControls.StudentViewGradeContol studentcontrol = new StudentControls.StudentViewGradeContol();
            panelInformation.Controls.Add(studentcontrol);
            
        }

        private void absencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            StudentControls.StudentViewAbsencesControl studentabsences = new StudentControls.StudentViewAbsencesControl();
            panelInformation.Controls.Add(studentabsences);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            UpdateControls.ChangePasswordControl changepassword = new UpdateControls.ChangePasswordControl();
            panelInformation.Controls.Add(changepassword);
        }

        private void changeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInformation.Controls.Clear();
            UpdateControls.ChangeInformationControl changeinformation = new UpdateControls.ChangeInformationControl();
            panelInformation.Controls.Add(changeinformation);
        }
    }
}
