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
using System.Resources;
using Data.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsView.StudentControls
{
    public partial class StudentGradeStatisticControl : UserControl
    {

        public StudentGradeStatisticControl(string language,Student student)
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
            List<string> subjects = new List<string>();
            for(int i=0;i<student.GradeRecords.Count;i++)
            {
                subjects.Add(student.GradeRecords.ElementAt(i).Subject);
            }
            subjects.Distinct();
            for(int i=0;i<subjects.Count;i++)
            {
                selectSubjectListbox.Items.Add(subjects[i]);
            }
            studentGrade = student;
        }

        private Student studentGrade;

        private bool Validate()
        {
            if(selectSubjectListbox.SelectedItem!=null)
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
            if (selectSubjectButton.Text == "Choose Subject")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void selectSubjectButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                List<GradeRecord> grades = new List<GradeRecord>(studentGrade.GradeRecords.Where(x => x.Subject == selectSubjectListbox.SelectedItem.ToString()));
                gradesChart.Palette = ChartColorPalette.Fire;
                gradesChart.Titles.Add(selectSubjectListbox.SelectedItem.ToString());
                for (int i = 0; i < grades.Count; i++)
                {
                    Series series = gradesChart.Series.Add(selectSubjectListbox.SelectedItem.ToString());
                    series.Points.Add(grades[i].Grade);
                }
            }
            else if(GetLanguage()=="Bulgarian")
            {
                MessageBox.Show("Не сте избрали предмет", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You haven't selected subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
