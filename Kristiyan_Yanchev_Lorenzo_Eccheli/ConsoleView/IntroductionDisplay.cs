using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleView
{
    public class IntroductionDisplay
    {
        public IntroductionDisplay()
        {
            Console.WriteLine("           Welcome to e-journal");
            Console.WriteLine("Choose an option : ");
            Console.WriteLine("1. Register");
            Console.WriteLine("2.Log in");
            Console.WriteLine("3.Exit");
        }

        private void Command()
        {
            int command = int.Parse(Console.ReadLine());
            if(command==1)
            {
                RegistrationDisplay registration = new RegistrationDisplay();
            }
            else if(command==2)
            {
                
            }
            else if(command==3)
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
