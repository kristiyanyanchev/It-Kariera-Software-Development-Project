using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    public partial class StudentGradeStatisticContol : UserControl
    {
        public StudentGradeStatisticContol()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if (selectSubjectListbox.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private string GetLanguage()
        {
            if(selectSubjectButton.Text=="Choose Subject")
            {
                return "English";
            }
            else
            {
                return "Bulgarian";
            }
        }

        private void selectSubjectButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else if(GetLanguage()=="English")
            {
                MessageBox.Show("You must select subject","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
