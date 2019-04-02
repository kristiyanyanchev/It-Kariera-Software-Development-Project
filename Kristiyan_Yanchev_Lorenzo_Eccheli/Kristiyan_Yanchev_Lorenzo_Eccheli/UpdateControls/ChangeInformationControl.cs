using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using System.Threading;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli.UpdateControls
{
    public partial class ChangeInformationControl : UserControl
    {
        string Language;
        public ChangeInformationControl(Teacher teacher,string language)
        {
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
        }

        public ChangeInformationControl(Student student,string language)
        {
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
        }

        public ChangeInformationControl(Parent parent,string language)
        {
            if (language == "Bulgarian")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("aa");
            }
            InitializeComponent();
        }
    }
}
