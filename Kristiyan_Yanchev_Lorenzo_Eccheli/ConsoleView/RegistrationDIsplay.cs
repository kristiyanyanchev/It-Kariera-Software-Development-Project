using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleView
{
    public class RegistrationDisplay
    {
        private DateTime dateofbirth;
        private string egn, name ,  family, role , password , email , address , phonenumber ;

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
        public string Family
        {
            get
            {
                return family;
            }
            set
            {
                if (value.Length >= 4 && value.Length < 12 && value != null)
                {
                    family = value;
                }
                else throw new Exception("Invalid family");
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                if (value != "Parent" || value!="Student" || value!="Principal" || value!="Teacher")
                {
                    role = value;
                }
                else
                {
                    throw new Exception("Invalid role");
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if(password.Length>0 && password.Length<20)
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Invalid password");
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if(email.Length>0 && email.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Invalid email");
                }
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if(address.Length>0 && address.Length<30)
                {
                    address = value;
                }
                else
                {
                    throw new Exception("Invalid adress");
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                if(phonenumber.Length!=10 && phonenumber[0]!='0')
                {
                    phonenumber = value;
                }
                else
                {
                    throw new Exception("Invalid phone number");
                }
            }
        }
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
