using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.TeacherControls
{
    public partial class TeacherAbsencesControl : UserControl
    {
        public TeacherAbsencesControl()
        {
            InitializeComponent();
        }

        public TeacherAbsencesControl(string language)
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

        private bool Validate()
        {
            if(classesListBox.SelectedItems!=null && studentsListBox.SelectedItems!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetLanguage()
        {
            if(newAbsenceButton.Text=="New Absence")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void newAbsenceButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
            else if (GetLanguage() == "English")
            {
                MessageBox.Show("You must select class and student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Трябва да изберете ученик и клас", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeAbsenceButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
            else if (GetLanguage() == "English")
            {
                MessageBox.Show("You must select class and student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Трябва да изберете ученик и клас", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
