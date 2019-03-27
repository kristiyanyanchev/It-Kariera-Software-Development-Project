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
    public partial class StudentRegistrationControl : UserControl
    {
        public StudentRegistrationControl(string language)
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
            if(ucnTextBox.Text!=null && String.Equals(birthdatePicker,DateTime.Today)==false && classnameTextBox.Text!=null)
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
