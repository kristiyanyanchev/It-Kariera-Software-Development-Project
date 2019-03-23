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
            DataGridViewRow dateRow = new DataGridViewRow(); 
            for(int i=0;i<student.GradeRecords.Count;i++)
            {
                dateRow.Cells[i].Value = student.GradeRecords.ElementAt(i).Date;
            }
            gradesDataGrid.Rows.Add(dateRow);

            DataGridViewRow gradeRow = new DataGridViewRow();
            for (int i = 0; i < student.GradeRecords.Count; i++)
            {
                gradeRow.Cells[i].Value = student.GradeRecords.ElementAt(i).Grade;
            }
            gradesDataGrid.Rows.Add(gradeRow);

            DataGridViewRow subjectRow = new DataGridViewRow();
            for (int i = 0; i < student.GradeRecords.Count; i++)
            {
                subjectRow.Cells[i].Value = student.GradeRecords.ElementAt(i).Grade;
            }
            gradesDataGrid.Rows.Add(subjectRow);
        }

        private string GetLanguage()
        {
            if(viewStatisticButton.Text=="View Statistics")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void viewStatisticButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentGradeStatisticControl studentgradestatistic = new StudentGradeStatisticControl(GetLanguage(),Student);
            this.Controls.Add(studentgradestatistic);
        }
    }
}
