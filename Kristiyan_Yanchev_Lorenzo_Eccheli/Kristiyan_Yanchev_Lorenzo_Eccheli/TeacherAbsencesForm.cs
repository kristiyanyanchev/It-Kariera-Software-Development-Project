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
    public partial class TeacherAbsencesForm : Form
    {
        public TeacherAbsencesForm()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if (classesListBox.SelectedItems != null && studentsListBox.SelectedItems != null)
            {
                return true;
            }
            else return false;
        }

        private void removeAbsenceButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else
            {
                MessageBox.Show("You havent selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void newAbsenceButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else
            {
                MessageBox.Show("You havent selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
