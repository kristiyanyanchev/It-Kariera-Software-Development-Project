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
using Data.Repositories;

namespace WinFormsView.TeacherControls
{
    public partial class TeacherGradeControl : UserControl
    {
        public TeacherGradeControl()
        {
            InitializeComponent();
        }

        public TeacherGradeControl(string language)
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
            if(classesListBox.SelectedItem!=null && studentsListbox.SelectedItem!=null &&
                gradesListBox.SelectedItem!=null)
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
            if(newGradeButton.Text=="New Grade")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void newGradeButton_Click(object sender, EventArgs e)
        {
            if(Validate() && gradeTextBox.Text!=null && Double.TryParse(gradeTextBox.Text,out double a))
            {
                
            }
            else if(GetLanguage()=="English")
            {
                MessageBox.Show("You must select item in list box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Трябва да изберете предмет", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeGradeButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else if(GetLanguage()=="English")
            {
                MessageBox.Show("You must select item in list box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Трябва да изберете предмет", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
