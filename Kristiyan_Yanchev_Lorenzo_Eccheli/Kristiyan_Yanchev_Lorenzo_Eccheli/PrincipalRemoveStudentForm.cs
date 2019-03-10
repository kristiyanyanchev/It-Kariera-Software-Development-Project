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
    public partial class PrincipalRemoveStudentForm : Form
    {
        public PrincipalRemoveStudentForm()
        {
            InitializeComponent();
        }

        public PrincipalRemoveStudentForm(string language)
        {
            if(language=="Bulgarian")
            {
                introductionLabel.Text = "Изгонване на ученик";
                firstnameLabel.Text = "Име";
                lastnameLabel.Text = "Фамилия";
                removeButton.Text = "Премахни";
                closeButton.Text = "Затвори";
            }
            else
            {
                introductionLabel.Text = "Removing student";
                firstnameLabel.Text = "First Name";
                lastnameLabel.Text = "Last Name";
                removeButton.Text = "Remove";
                closeButton.Text = "Close";
            }
        }

        private bool ValidateData()
        {
            if(firstNameTextBox.Text!=null && lastNameTextBox!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalMainForm principalmain = new PrincipalMainForm();
            principalmain.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                MessageBox.Show("You successfully removed the student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You must write correct first name and last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrincipalRemoveStudentForm_FormClosing(object sender, FormClosingEventArgs e)
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
