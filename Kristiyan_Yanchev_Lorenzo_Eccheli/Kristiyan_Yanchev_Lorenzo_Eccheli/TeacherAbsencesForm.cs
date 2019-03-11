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
    public partial class TeacherAbsencesForm : Form
    {
        public TeacherAbsencesForm()
        {
            InitializeComponent();
        }

        private void newAbsenceButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherMainForm teachermain = new TeacherMainForm();
            teachermain.ShowDialog();
        }
    }
}
