using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.RegistrationControls
{
    public partial class ParentRegistrationControl : UserControl
    {
        public ParentRegistrationControl()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if(usernameOfChildTextBox.Text!=null)
            {
                //add if text box has numbers
                return true;
            }
            else
            {
                return false;
            }
        }

        public string NameOfChild
        {
            get { return usernameOfChildTextBox.Text; }
            set
            {
                if (Validate()) usernameOfChildTextBox.Text = value;
                else throw new Exception("Wrong text box");
            }
        }
    }
}
