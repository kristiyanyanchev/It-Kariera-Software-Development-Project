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
        public string Ucn { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ValidationCode { get; set; }

        public Class Class { get; set; }

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
    }
}
