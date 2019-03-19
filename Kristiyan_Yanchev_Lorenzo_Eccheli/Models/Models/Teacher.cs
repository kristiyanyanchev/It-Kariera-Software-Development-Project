using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]
        public string Position { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [Required]
        public string ValidationCode { get; set; }

        public Class Class { get; set; }
        public string Address { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string subject, string position, string validationCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            Position = position;
            ValidationCode = validationCode;
        }

        public Teacher(int id, string firstName, string lastName, string subject, string phoneNumber, string email, 
            string position, string username, string password, string validationCode, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
            Username = username;
            Password = password;
            ValidationCode = validationCode;
            Address = address;
        }
    }
}
