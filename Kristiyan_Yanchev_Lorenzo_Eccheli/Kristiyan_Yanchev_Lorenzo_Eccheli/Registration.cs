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

        public Registration(string language)
        {
            if (language == "Bulgarian")
            {
                InitializeComponent();
                introductionLabel.Text = "Регистрация в електронния училищен дневник";
                partoneLabel.Text = "Част 1";
                nameLabel.Text = "Име";
                passwordLabel.Text = "Парола";
                visibleCheckBox.Text = "Видимост";
                emailLabel.Text = "Емайл";
                addressLabel.Text = "Адрес";
                phoneLabel.Text = "Телефонен номер";
                familyLabel.Text = "Фамилия";
                roleLabel.Text = "Длъжност";
            }
            else if(language=="English")
            {
                InitializeComponent();
                introductionLabel.Text = "Registration  to School E-Journal";
                partoneLabel.Text = "Part 1";
                nameLabel.Text = "Name";
                passwordLabel.Text = "Password";
                visibleCheckBox.Text = "Visible";
                emailLabel.Text = "E-mail";
                addressLabel.Text = "Address";
                phoneLabel.Text = "Phone number";
                familyLabel.Text = "Family";
                roleLabel.Text = "Role";
            }
        }

        private bool ValidateData()
        {
            if(nameTextBox.Text!=null && familyTextBox.Text!=null && 
               passwordTextBox.Text!=null && emailTextBox.Text!=null && 
               addressTextBox.Text!=null && phonenumberTextBox.Text!=null && 
               roleComboBox.SelectedItem!=null)
            {
                return true;
            }
            return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                this.Hide();
                StudentFormRegistration studentregistration = new StudentFormRegistration();
                studentregistration.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(visibleCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void FormCLosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dialog==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
