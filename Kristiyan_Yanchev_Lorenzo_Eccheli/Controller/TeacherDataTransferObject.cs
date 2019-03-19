using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class TeacherDataTransferObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public string ValidationCode { get; set; }

        public string Class { get; set; }
        public string Address { get; set; }

        public TeacherDataTransferObject(string firstName, string lastName, string subject, string phoneNumber,
            string email, string position, string username, string password, string validationCode, string @class, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
            Username = username;
            Password = password;
            ValidationCode = validationCode;
            Class = @class;
            Address = address;
        }
    }
}
