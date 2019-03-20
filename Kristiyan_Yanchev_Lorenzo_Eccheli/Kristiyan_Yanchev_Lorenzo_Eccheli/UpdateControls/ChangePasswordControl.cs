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
    public partial class ChangePasswordControl : UserControl
    {
        public ChangePasswordControl()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if(oldPasswordTextBox.Text!=null && newPasswordTextBox.Text!=null && confirmNewPasswordTextBox.Text!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleCheckBox.Checked)
            {
                newPasswordTextBox.PasswordChar = '\0';
                confirmNewPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                newPasswordTextBox.PasswordChar = '*';
                confirmNewPasswordTextBox.PasswordChar = '*';
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
