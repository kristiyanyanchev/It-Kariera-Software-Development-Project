using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;
using Data.Models;
using System.Threading;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.ParentControls
{
    public partial class ParentViewGradeControl : UserControl
    {

        public ParentViewGradeControl(string language,Parent parent)
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

        private void AddFields(Parent parent)
        {
            
        }
    }
}
