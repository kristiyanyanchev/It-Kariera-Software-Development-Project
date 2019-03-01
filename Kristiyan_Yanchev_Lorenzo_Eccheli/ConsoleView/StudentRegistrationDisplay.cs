using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleView
{
    public class StudentRegistrationDisplay
    {
        private DateTime dateofbirth;
        private string egn;

        public DateTime DateBirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                if (value.Year - DateTime.Today.Year >= 7 && value.Year - DateTime.Today.Year <= 19)
                {
                    dateofbirth = value;
                }
                else throw new Exception("Your age must be between 7 or 19");
            }
   
        }
        public string EGN
        {
            get
            {
                return egn;
            }
            set
            {
                if (value.Length == 10)
                {
                    egn = value;
                }
                else throw new Exception("Your EGN must have 10 letters");
            }
        }
        public string ClassName { get; set; }

        public StudentRegistrationDisplay()
        {
            Console.Write("Enter your date of birth :");
            DateBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter your EGN :");
            EGN = Console.ReadLine();
            Console.Write("Enter your class name :");
            ClassName = Console.ReadLine();
        }
    }
}
