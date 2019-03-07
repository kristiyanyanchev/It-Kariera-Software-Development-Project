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
            this.Hide();
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
    }
}
