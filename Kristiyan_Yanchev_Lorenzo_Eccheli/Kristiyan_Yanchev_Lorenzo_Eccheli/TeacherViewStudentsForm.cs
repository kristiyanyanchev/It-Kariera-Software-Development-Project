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
    public partial class TeacherViewStudentsForm : Form
    {
        public TeacherViewStudentsForm()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if(searchFirstNameTextBox.Text!=null && searchLastNameTextBox.Text!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
