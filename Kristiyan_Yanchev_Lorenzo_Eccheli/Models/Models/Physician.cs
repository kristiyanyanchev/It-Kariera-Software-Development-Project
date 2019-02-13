using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Physician
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

        public Physician(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Physician(int id, string firstName, string lastName, string email) : this(id, firstName, lastName)
        {
            Email = email;
        }

        public Physician(int id, string firstName, string lastName, string email, string phoneNumber) : this(id, firstName, lastName, email)
        {
            PhoneNumber = phoneNumber;
        }

        public Physician(int id, string firstName, string lastName, string email, string phoneNumber, string address) : this(id, firstName, lastName, email, phoneNumber)
        {
            Address = address;
        }
    }
}
