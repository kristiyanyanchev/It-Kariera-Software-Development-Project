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

        public Parent(int id, string firstName, string lastName, string address)
        {
            string regexPatternNames = @"[A-Z][a-z]+";
            string regexPatternAddress = @"[ A-Za-z1-9.-]+";
            if (id <0)
            {
                throw new ArgumentException("Id should be more than 0");
            }

            if (Regex.Match(firstName,regexPatternNames).Length != firstName.Length)
            {
                throw new ArgumentException("First name can contain only letters");
            }

            if (Regex.Match(lastName, regexPatternNames).Length != lastName.Length)
            {
                throw new ArgumentException("Last name can contain only letters");
            }

            if (Regex.Match(address, regexPatternAddress).Length != address.Length || address == string.Empty)
            {
                throw new ArgumentException("Address contains forbidden characters");
            }

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public Parent(int id, string firstName, string lastName, string address, string email) : this(id, firstName, lastName, address)
        {
            Email = email;
        }

        public Parent(int id, string firstName, string lastName, string address, string email, string phoneNumber) : this(id, firstName, lastName, address, email)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
