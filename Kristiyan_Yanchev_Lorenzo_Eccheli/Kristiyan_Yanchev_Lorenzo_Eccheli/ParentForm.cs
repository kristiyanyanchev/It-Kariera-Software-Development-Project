﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        public ParentForm(string language)
        {
            InitializeComponent();
            if(language=="Bulgarian")
            {
                selectButton.Text = "Избери";
                gradeButton.Text = "Оценка";
                closeButton.Text = "Затвори";
                languageLabel.Text = "Език";
                emailLabel.Text = "Имейл";
                phonenumberLabel.Text = "Телефонен номер";
            }
            else
            {
                selectButton.Text = "Select";
                gradeButton.Text = "Grade";
                closeButton.Text = "Close";
                languageLabel.Text = "Language";
                emailLabel.Text = "Email";
                phonenumberLabel.Text = "Phone Number";
            }
        }

        private bool Validate()
        {
            if (teacherListBox.SelectedItem.ToString() != null)
            {
                return true;
            }
            else return false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else
            {
                MessageBox.Show("You havent selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            StudentViewGradesForm studentgrade = new StudentViewGradesForm();
            studentgrade.ShowDialog();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
