using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ValidationCode { get; set; }

        public ICollection<Student> Children { get; set; }

        public Parent()
        {

        }

        public Parent(string firstName, string lastName, string address, string validationCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ValidationCode = validationCode;
        }
    }
}
