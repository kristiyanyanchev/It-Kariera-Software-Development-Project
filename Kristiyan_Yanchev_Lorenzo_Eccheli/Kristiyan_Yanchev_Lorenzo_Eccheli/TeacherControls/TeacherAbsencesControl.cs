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
    public partial class TeacherAbsencesControl : UserControl
    {
        public TeacherAbsencesControl(string language,Teacher teacher)
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
            foreach (var @class in classes.List())
            {
                classesListBox.Items.Add(@class.ToString());
            }

            teacherGetter = teacher;
        }

        private Teacher teacherGetter;

        private bool Validate()
        {
            
            if(classesListBox.SelectedItem!=null && studentsListBox.SelectedItem != null)
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
                var students = new StudentsRepository();
                var absences = new AbsencesRepository();
                var studentId = int.Parse(studentsListBox.SelectedItem.ToString().Split(' ').First());
                absences.Add(new Absence(studentId,DateTime.Now,isLateCheckBox.Checked));


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
                var students = new StudentsRepository();
                var absences = new AbsencesRepository();
                var studentId = int.Parse(studentsListBox.SelectedItem.ToString().Split(' ').First());
                absences.Delete(absences.List().Where(x => x.StudentId == studentId).Last());
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

        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var @class = new ClassesRepository().List().Single(x => x.Name == classesListBox.SelectedItem.ToString());
            var students = new StudentsRepository().List().Where(x => x.ClassId == @class.Id);
            studentsListBox.DataSource = students.Select(x => x.ToString()).ToList();
            
        }
    }
}
