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
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm(string language)
        {
            InitializeComponent();
            if (language == "Bulgarian")
            {
                introductionLabel.Text = "Регистрация в електронния дневник";
                parttwoLabel.Text = "Част 2";
                dateofbirthLabel.Text = "Дата на раждане";
                ucnLabel.Text = "ЕГН";
                registrationButton.Text = "Регистрация";
                classLabel.Text = "Клас";
                exitButton.Text = "Изход";
                formToolTip.SetToolTip(studentdateofbirth,"Напишете си датата на раждане.");
                formToolTip.SetToolTip(egnTextBox,"Напишете ЕГН-то си.");
                formToolTip.SetToolTip(classTextBox,"Напишете кой клас сте.");
                formToolTip.SetToolTip(registrationButton,"Регистрацията е довършена ако горните полета са попълнени вярно.");
                formToolTip.SetToolTip(exitButton, "Излезте от прилойението.");
            }
            else
            {
                introductionLabel.Text = "Registration  to School E-Journal";
                parttwoLabel.Text ="Part 2";
                dateofbirthLabel.Text = "Date of birth";
                ucnLabel.Text = "EGN";
                registrationButton.Text = "Registration";
                classLabel.Text = "Class";
                exitButton.Text = "Exit";
                formToolTip.SetToolTip(studentdateofbirth,"Enter your date of birth.");
                formToolTip.SetToolTip(egnTextBox,"Enter your EGN");
                formToolTip.SetToolTip(classTextBox,"Enter your class.");
                formToolTip.SetToolTip(registrationButton,"Your registration will be done if everything is correct .");
                formToolTip.SetToolTip(exitButton, "Exit the application.");
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
