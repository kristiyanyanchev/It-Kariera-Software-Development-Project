using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class ParentForm : Form
    {
        private Parent Parent;
        private string Language;
        public ParentForm(Parent parent)
        {
            Parent = parent;
            InitializeComponent();

        }

        public ParentForm(string language, Parent parent)
        {
            Parent = parent;
            Language = language;

            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
            teacherListBox.DataSource = new TeachersRepository().List();
            var gradeControl = new ParentControls.ParentViewGradeControl(Language, Parent);
            panelInformation.Controls.Add(gradeControl);
        }

        private bool Validate()
        {
            if (teacherListBox.SelectedItem.ToString() != null)
            {
                return true;
            }
            else return false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                var selectedTeacherId = int.Parse(teacherListBox.SelectedItem.ToString().Split(' ').First());
                var selectedTeacher = new TeachersRepository().GetById(selectedTeacherId);

                var contactControl = new ParentControls.ParentContactTeacherControl(selectedTeacher, Language);
                panelInformation.Controls.Clear();
                panelInformation.Controls.Add(contactControl);
            }
            else
            {
                MessageBox.Show("You havent selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {

            var gradeControl = new ParentControls.ParentViewGradeControl(Language, Parent);
            panelInformation.Controls.Clear();
            panelInformation.Controls.Add(gradeControl);


        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (languageComboBox.SelectedItem.ToString() == "English" ||
                languageComboBox.SelectedItem.ToString() == "Английски")
            {
                Language = "English";
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Language = "Bulgarian";
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
            teacherListBox.DataSource = new TeachersRepository().List();
            var gradeControl = new ParentControls.ParentViewGradeControl(Language, Parent);
            panelInformation.Controls.Add(gradeControl);
        }

    }
}
