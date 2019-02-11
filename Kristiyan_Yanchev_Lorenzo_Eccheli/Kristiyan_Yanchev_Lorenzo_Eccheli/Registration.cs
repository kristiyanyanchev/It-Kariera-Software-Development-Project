using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private bool ValidateData()
        {
            if(nameTextBox.Text!=null && familyTextBox.Text!=null && passwordTextBox.Text!=null && emailTextBox.Text!=null && addressTextBox.Text!=null && phonenumberTextBox.Text!=null && roleComboBox.SelectedItem!=null)
            {
                return true;
            }
            return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                this.Hide();
                StudentFormRegistration studentregistration = new StudentFormRegistration();
                studentregistration.ShowDialog();
            }
        }
    }
}
