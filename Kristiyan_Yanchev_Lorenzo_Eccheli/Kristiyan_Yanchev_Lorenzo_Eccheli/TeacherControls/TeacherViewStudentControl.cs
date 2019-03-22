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

namespace WinFormsView.TeacherControls
{
    public partial class TeacherViewStudentControl : UserControl
    {
        public TeacherViewStudentControl()
        {
            InitializeComponent();
        }

        public TeacherViewStudentControl(string language)
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
            if(searchFirstNameTextBox.Text!=null && searchLastNameTextBox.Text!=null)
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
            if(firstNameLabel.Text=="First Name")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else if(GetLanguage()=="English")
            {
                MessageBox.Show("You must write first name or last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Трябва да напишете име или фамилия", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
