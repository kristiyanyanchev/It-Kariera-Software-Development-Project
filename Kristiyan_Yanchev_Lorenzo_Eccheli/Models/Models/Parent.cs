using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Data.Models
{
    public class Parent : IParent
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

        public ICollection<IStudent> Children { get; set; }

        public Parent(string firstName, string lastName, string address)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("FirstName cannot be null");
            }
            if (lastName == null)
            {
                throw new ArgumentNullException("LastName cannot be null");
            }
            if (address == null)
            {
                throw new ArgumentNullException("Address cannot be null");
            }

            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Children = new List<IStudent>();
        }

        public Parent(string firstName, string lastName, string address, string email, string phoneNumber) : this(firstName,lastName,address)
        {
            if (email == null)
            {
                throw new ArgumentNullException("Email cannot be null");
            }
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("PhoneNumber cannot be null");
            }
            Email = email;
            PhoneNumber = phoneNumber;
            
        }
        

        

        

       
    }
}
