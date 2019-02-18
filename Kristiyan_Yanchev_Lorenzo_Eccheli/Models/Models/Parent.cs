using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Data.Models
{
    public class Parent
    {   
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(255),MinLength(2)]
        public string FirstName { get; set; }

        [Required, MaxLength(255), MinLength(2)]
        public string LastName { get; set; }

        [Required, MaxLength(255), MinLength(10)]
        public string Address { get; set; }

        [MaxLength(255),MinLength(5)]
        public string Email { get; set; }
        [MaxLength(10),MinLength(10)]
        public string PhoneNumber { get; set; }

        public ICollection<Student> Children { get; set; }

        public Parent(string firstName, string lastName, string address, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Children = new List<Student>();
        }

        public Parent(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
