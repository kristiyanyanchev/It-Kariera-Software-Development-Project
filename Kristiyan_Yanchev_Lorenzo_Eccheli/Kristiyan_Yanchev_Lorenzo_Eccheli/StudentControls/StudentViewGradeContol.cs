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
            DataGridViewRow dataRow = (DataGridViewRow)gradesDataGrid.Rows[0].Clone();  
            for(int i=0;i<student.GradeRecords.Count;i++)
            {
                dataRow.Cells[i].Value = student.GradeRecords.ElementAt(i).Date;
            }
            gradesDataGrid.Rows.Add(dataRow);

            DataGridViewRow gradeRow = (DataGridViewRow)gradesDataGrid.Rows[1].Clone();
            for (int i = 0; i < student.GradeRecords.Count; i++)
            {
                dataRow.Cells[i].Value = student.GradeRecords.ElementAt(i).Grade;
            }
            gradesDataGrid.Rows.Add(dataRow);

            DataGridViewRow subjectRow = (DataGridViewRow)gradesDataGrid.Rows[2].Clone();
            for (int i = 0; i < student.GradeRecords.Count; i++)
            {
                subjectRow.Cells[i].Value = student.GradeRecords.ElementAt(i).Grade;
            }
            gradesDataGrid.Rows.Add(dataRow);
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
            StudentControls.StudentGradeStatisticControl studentgradestatistic = new StudentGradeStatisticControl(GetLanguage(),Student);
            this.Controls.Add(studentgradestatistic);
        }
    }
}
