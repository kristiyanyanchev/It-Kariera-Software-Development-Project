using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleView
{
    public class RegistrationDisplay
    {
        private DateTime dateofbirth;
        private string egn, name;//,family,role,password,email,address,phonenumber,dateofbirth;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 4 && value.Length < 12 && value != null)
                {
                    name = value;
                }
                else throw new Exception("Invalid name");
            }
        }
        public string Family { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
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
            else if(Role=="Teacher")
            {

            }
        }
    }
}
