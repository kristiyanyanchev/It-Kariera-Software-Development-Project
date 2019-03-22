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

namespace WinFormsView.UpdateControls
{
    public partial class ChangeInformationControl : UserControl
    {
        public ChangeInformationControl(string language)
        {
            if(language=="English")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
        }

        private bool Validation()
        {
            if (emailTextBox.Text != null && emailTextBox.Text.Contains("@") || (PhoneNumberTextBox.Text != null &&
                PhoneNumberTextBox.Text.Length == 10))
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
