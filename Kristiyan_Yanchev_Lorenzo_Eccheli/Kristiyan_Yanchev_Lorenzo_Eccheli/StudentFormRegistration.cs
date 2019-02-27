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
    public partial class StudentFormRegistration : Form
    {
        public StudentFormRegistration(string language)
        {
            InitializeComponent();
            if (language == "Bulgarian")
            {
                introductionLabel.Text = "Регистрация в електронния дневник";
                parttwoLabel.Text = "Част 2";
                dateofbirthLabel.Text = "Дата на раждане";
                egnLabel.Text = "ЕГН";
                registrationButton.Text = "Регистрация";
                classLabel.Text = "Клас";
            }
            else
            {
                introductionLabel.Text = "Registration  to School E-Journal";
                parttwoLabel.Text ="Part 2";
                dateofbirthLabel.Text = "Date of birth";
                egnLabel.Text = "EGN";
                registrationButton.Text = "Registration";
                classLabel.Text = "Class";
            }
        }

        private bool ValidateData()
        {
            string egnnumbers = egnTextBox.Text;
            if (Double.TryParse(egnTextBox.Text, out double a)&& egnnumbers.Length==10 && classTextBox.Text != null && DateTime.Today.Year - studentdateofbirth.Value.Year >= 7 &&
                DateTime.Today.Year - studentdateofbirth.Value.Year <= 19)
            {
                return true;
            }
            else return false;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }
    }
}
