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
            List<Absence> absences = new List<Absence>(student.Absences);
            DataGridViewRow dateofstartingrow = new DataGridViewRow();
            for (int i=0;i<absences.Count;i++)
            {
                //dateofstartingrow.Cells[i].Value=absences[i].Period
            }
        }
    }
}
