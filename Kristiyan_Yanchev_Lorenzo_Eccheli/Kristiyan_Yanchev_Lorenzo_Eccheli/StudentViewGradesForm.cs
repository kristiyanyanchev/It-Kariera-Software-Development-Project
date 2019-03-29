using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Repositories;
using System.Threading;
using Data.Models;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class StudentViewGradesForm : Form
    {
        public StudentViewGradesForm(string language,Student student)
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

            for(int i=0;i<student.GradeRecords.Count;i++)
            {
                gradesDataGrid.Rows[i].Cells[0].Value = student.GradeRecords.ElementAt(i).Date;
                gradesDataGrid.Rows[i].Cells[1].Value = student.GradeRecords.ElementAt(i).Grade;
                gradesDataGrid.Rows[i].Cells[2].Value = student.GradeRecords.ElementAt(i).Subject;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewStatisticButton_Click(object sender, EventArgs e)
        {
            StudentGradesStatisticsForm studentstatistic = new StudentGradesStatisticsForm();
            studentstatistic.ShowDialog();
        }
    }
}
