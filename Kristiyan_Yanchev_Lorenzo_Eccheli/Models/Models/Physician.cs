using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Physician : IPhysician
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(30),MinLength(2)]
        public string FirstName { get; set; }

        [Required,MaxLength(30),MinLength(2)]
        public string LastName { get; set; }

        public string Email { get; set; }

        [MinLength(10),MaxLength(10)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Physician(string firstName, string lastName, string email, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Physician(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
