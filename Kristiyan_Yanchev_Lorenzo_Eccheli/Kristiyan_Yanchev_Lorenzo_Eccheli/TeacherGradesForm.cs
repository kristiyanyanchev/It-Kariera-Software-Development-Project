using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;
using Data.Models;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class TeacherGradesForm : Form
    {
        public TeacherGradesForm()
        {
            InitializeComponent();
        }

        public TeacherGradesForm(string language,Teacher teacher)
        {
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
            
            for(int i=0;i<teacher.Class.Students.Count;)
            /*
            if (language == "Bulgarian")
            {

                instructionLabel.Text = "Избери оценка можете да я махнете или да добавите нова";
                gradeLabel.Text = "Оценка";
                removeGradeButton.Text = "Премахни Оценката";
                newGradeButton.Text = "Нова Оценка";
                closeButton.Text = "Затвори";
            }
            else
            {
                instructionLabel.Text = "Select grade and you can remove it or add new grade";
                gradeLabel.Text = "Grade";
                removeGradeButton.Text = "Remove Grade";
                newGradeButton.Text = "New Grade";
                closeButton.Text = "Close";
            }
            */
        }

        private Teacher teacher;

        private bool ValidateData()
        {
            if(classesListBox.SelectedItem!=null && studentsListbox.SelectedItem!=null &&
                gradesListBox.SelectedItem!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void removeGradeButton_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                gradesListBox.Items.Remove(gradesListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("There is not selected grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void newGradeButton_Click(object sender, EventArgs e)
        {
            //if(gradeTextBox.Text!=null && int.TryParse(gradeTextBox.Text,out int a))
            //{
            //    gradesListBox.Items.Add(gradesListBox.Text);
            //}
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (languageComboBox.SelectedItem.ToString() == "English" ||
                languageComboBox.SelectedItem.ToString() == "Английски")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
        }
    }
}
