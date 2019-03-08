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
            this.Hide();
            PrincipalRemoveStudentForm principalremovestudent = new PrincipalRemoveStudentForm();
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
            
        }

        private void viewStudentButton_Click(object sender, EventArgs e)
        {

        }

        private void sickLeaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalSubjectsForm prinicpalsubject = new PrincipalSubjectsForm();
            prinicpalsubject.ShowDialog();
        }
    }
}
