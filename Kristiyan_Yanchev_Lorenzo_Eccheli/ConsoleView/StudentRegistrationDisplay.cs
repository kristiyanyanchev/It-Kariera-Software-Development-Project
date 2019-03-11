using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleView
{
    public class StudentRegistrationDisplay
    {
        public string ClassName { get; set; }

        public StudentRegistrationDisplay()
        {
            Console.Write("Enter your date of birth :");
            //DateBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter your EGN :");
            //EGN = Console.ReadLine();
            Console.Write("Enter your class name :");
            ClassName = Console.ReadLine();
        }
    }
}
