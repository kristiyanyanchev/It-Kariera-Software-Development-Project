using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.UpdateControls
{
    public partial class ChangeInformationControl : UserControl
    {
        public ChangeInformationControl()
        {
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
