using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using System.Threading;

namespace WinFormsView.ParentControls
{
    public partial class ParentContactTeacherControl : UserControl
    {
        public ParentContactTeacherControl(Teacher teacher,string language)
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

            firstNameTextBox.Text = teacher.FirstName;
            lastNameTextBox.Text = teacher.LastName;
            emailTextBox.Text = teacher.Email;
            phoneNumberTextBox.Text = teacher.PhoneNumber;
        }
    }
}
