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
    public partial class StudentViewGradesForm : Form
    {
        public StudentViewGradesForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewStatisticButton_Click(object sender, EventArgs e)
        {
            StudentGradesStatisticsForm studentstatistic = new StudentGradesStatisticsForm();
            studentstatistic.ShowDialog();
        }
    }
}
