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
    public partial class PrincipalBonusesForm : Form
    {
        public PrincipalBonusesForm()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if(amountTextBox.Text!=null && Double.TryParse(amountTextBox.Text,out double a))
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
            PrincipalMainForm principalmain = new PrincipalMainForm();
            principalmain.ShowDialog();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalBonusesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
