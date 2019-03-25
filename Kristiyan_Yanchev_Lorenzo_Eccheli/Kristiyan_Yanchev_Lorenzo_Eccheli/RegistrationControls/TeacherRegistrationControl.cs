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

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.RegistrationControls
{
    public partial class TeacherRegistrationControl : UserControl
    {
        public TeacherRegistrationControl(string language)
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

        public bool Validate()
        {
            if(classnameTextBox.Text!=null && subjectTextBox.Text!=null && positionTextBox.Text!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
