using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;
using Data.Models;
using System.Threading;

namespace WinFormsView.ParentControls
{
    public partial class ParentViewGradeControl : UserControl
    {

        public ParentViewGradeControl(string language,Parent parent)
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
            var parentsRepo = new ParentsRepository();
            var children = parent.Children;
            var students = new StudentsRepository();
            var grades = new GradesRepository().List().Where(x => children.Select( y=> y.Id).Contains(x.StudentId))
                .Select(x => new { x.Student.FirstName, x.Subject, x.Grade, x.Date }).ToList();
            gradesDataGrid.DataSource = grades;
        }

        private void AddFields(Parent parent)
        {
            
        }
    }
}
