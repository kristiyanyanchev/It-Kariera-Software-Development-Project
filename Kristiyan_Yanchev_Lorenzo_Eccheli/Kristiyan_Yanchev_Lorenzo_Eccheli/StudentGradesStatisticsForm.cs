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
    public partial class StudentGradesStatisticsForm : Form
    {
        public StudentGradesStatisticsForm()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if (selectSubjectListbox.SelectedItem.ToString() != null)
            {
                return true;
            }
            else return false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void selectSubjectButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
        }
    }
}
