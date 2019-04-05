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

namespace WinFormsView.StudentControls
{
    public partial class StudentViewAbsencesControl : UserControl
    {

        public StudentViewAbsencesControl(string language, Student student)
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
            AbsencesRepository absences = new AbsencesRepository();
            var studentAbs = absences.List().Where(x => x.StudentId == student.Id).Select(x => new { x.Period, x.IsLate }).ToList();

            absencesDataGrid.DataSource = studentAbs;
        }
    }
}
