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

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class StudentGradesStatisticsForm : Form
    {
        public StudentGradesStatisticsForm()
        {
            InitializeComponent();
        }

        public StudentGradesStatisticsForm(string language)
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
        }

        private bool Validate()
        {
            if (selectSubjectListbox.SelectedItem.ToString() != null)
            {
                return true;
            }
            else return false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void selectSubjectButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
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
