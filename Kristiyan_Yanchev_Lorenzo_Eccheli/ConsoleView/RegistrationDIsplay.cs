using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleView
{
    public class RegistrationDisplay
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public RegistrationDisplay()
        {
            Console.Write("Name :");
            Name = Console.ReadLine();
            Console.Write("Family :");
            Family = Console.ReadLine();
            Console.Write("Role :");
            Role = Console.ReadLine();
            Console.Write("Password :");
            Password = Console.ReadLine();
            Console.Write("Email :");
            Email = Console.ReadLine();
            Console.Write("Address :");
            Address = Console.ReadLine();
            Console.Write("Phone number :");
            PhoneNumber = Console.ReadLine();
            if(Role=="Student")
            {
                StudentRegistrationDisplay studentregistration = new StudentRegistrationDisplay();
            }
        }
    }
}
