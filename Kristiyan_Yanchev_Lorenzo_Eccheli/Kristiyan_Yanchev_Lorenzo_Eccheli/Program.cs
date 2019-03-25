using Data.Models;
using Data.Repositories;
using Data.ValidationCodesSetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kristiyan_Yanchev_Lorenzo_Eccheli
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(ValidationCodeSetUp.IsExecuted() != true)
            {
                var setUp = new ValidationCodeSetUp();
                setUp.Execute();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
        }
    }
}
