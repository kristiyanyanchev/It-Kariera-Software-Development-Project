using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.StudentControls
{
    public partial class StudentViewGradeContol : UserControl
    {
        public StudentViewGradeContol()
        {
            InitializeComponent();
        }

        private void viewStatisticButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentControls.StudentGradeStatisticControl studentgradestatistic = new StudentGradeStatisticControl();
            this.Controls.Add(studentgradestatistic);
        }
    }
}
