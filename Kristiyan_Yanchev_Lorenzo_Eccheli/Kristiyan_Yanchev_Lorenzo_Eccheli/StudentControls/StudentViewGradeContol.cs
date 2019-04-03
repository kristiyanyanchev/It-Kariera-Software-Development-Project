using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Data.Models;
using WinFormsView.StudentControls;
using Data.Repositories;

namespace WinFormsView.StudentControls
{
    public partial class StudentViewGradeContol : UserControl
    {

        public StudentViewGradeContol(string language,Student student)
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
            AddRows(student);
            Student = student;
        }

        private Student Student;

        private void AddRows(Student student)
        {
            var grades = new GradesRepository().List().Where(x => x.StudentId == student.Id).Select(x => new {x.Date,x.Grade,x.Subject }).ToList();
            gradesDataGrid.DataSource = grades;
            
        }

       

        
    }
}
