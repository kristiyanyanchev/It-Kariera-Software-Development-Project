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
using Data.Models;
using Data.Repositories;

namespace WinFormsView.TeacherControls
{
    public partial class TeacherGradeControl : UserControl
    {
        public TeacherGradeControl()
        {
            InitializeComponent();
            
        }

        public TeacherGradeControl(string language,Teacher teacher)
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

            var classes = new ClassesRepository();
            classesListBox.DataSource = classes.List().ToList();

            teacherGetter = teacher;
        }

        private Teacher teacherGetter;
        private bool Validate()
        {
            if(classesListBox.SelectedItem!=null && studentsListbox.SelectedItem!=null)
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
                var studentId = int.Parse(studentsListbox.SelectedItem.ToString().Split(' ').First());
                var grade = new GradeRecord(double.Parse(gradeTextBox.Text), DateTime.Now, teacherGetter.Subject, studentId);
                var grades = new GradesRepository();
                grades.Add(grade);
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

        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var @class = new ClassesRepository().List().Single(x => x.Name == classesListBox.SelectedItem.ToString());
            var students = new StudentsRepository().List().Where(x => x.ClassId == @class.Id);
            studentsListbox.DataSource = students.Select(x => x.ToString()).ToList();
        }

        private void studentsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var grades = new GradesRepository();
            var studentId = int.Parse(studentsListbox.SelectedItem.ToString().Split(' ').First());
           gradesListBox.DataSource = grades.List().Where(x => x.StudentId == studentId).ToList();

        }
    }
}
