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
    public partial class ParentForm : Form
    {
        public Parent Parent { get; set; }
        public ParentForm(Parent parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        public ParentForm(string language,Parent parent)
        {
            Parent = parent;

            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
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
            if(Validate())
            {

            }
            else
            {
                MessageBox.Show("You havent selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            StudentViewGradesForm studentgrade = new StudentViewGradesForm();
            studentgrade.ShowDialog();
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
