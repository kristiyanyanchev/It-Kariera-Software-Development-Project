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

namespace WinFormsView.StudentControls
{
    public partial class StudentGradeStatisticControl : UserControl
    {
        public StudentGradeStatisticControl()
        {
            InitializeComponent();
        }

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
        }

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
