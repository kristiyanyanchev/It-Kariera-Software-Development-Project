using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class StudentDataTransferObject
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ValidationCode { get; set; }
        public string Class { get; set; }
        public string Ucn { get; set; }
        public DateTime BirthDate { get; set; }

        public StudentDataTransferObject(string username, string firstName, string lastName, string password, string email, string address,
            string phoneNumber, string validationCode, string @class, string ucn, DateTime birthDate)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            ValidationCode = validationCode;
            Class = @class;
            Ucn = ucn;
            BirthDate = birthDate;
        }
    }
}
