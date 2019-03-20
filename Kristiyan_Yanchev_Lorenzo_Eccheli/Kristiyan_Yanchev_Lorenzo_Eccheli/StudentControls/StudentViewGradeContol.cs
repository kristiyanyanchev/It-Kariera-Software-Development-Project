using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.StudentControls
{
    public partial class StudentViewGradeContol : UserControl
    {
        public StudentViewGradeContol()
        {
            InitializeComponent();
        }

        public StudentViewGradeContol(string language)
        {
            if (language == "English")
            {

                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            InitializeComponent();
        }

        private string GetLanguage()
        {
            if(viewStatisticButton.Text=="View Statistics")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void viewStatisticButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentControls.StudentGradeStatisticControl studentgradestatistic = new StudentGradeStatisticControl(GetLanguage());
            this.Controls.Add(studentgradestatistic);
        }
    }
}
