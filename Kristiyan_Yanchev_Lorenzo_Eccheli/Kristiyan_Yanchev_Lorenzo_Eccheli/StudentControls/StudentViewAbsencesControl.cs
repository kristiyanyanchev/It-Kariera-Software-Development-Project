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

        public StudentViewAbsencesControl(string language,Student student)
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
            var studentAbs = absences.List().Where(x => x.StudentId == student.Id).ToList();

            for (int i = 0; i < studentAbs.Count; i++)
            {
                absencesDataGrid.Rows[i].Cells[0].Value = studentAbs[i].Period;
                absencesDataGrid.Rows[i].Cells[1].Value = studentAbs[i].IsLate;
            }
        }
    }
}
