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
        [Required,MaxLength(30),MinLength(2)]
        public string FirstName { get; set; }
        [Required, MaxLength(255), MinLength(2)]
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        [MaxLength(10),MinLength(10)]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]
        public string Position { get; set; }
        [MaxLength(10),MinLength(10)]
        public string UCN { get; set; }

        public Physician Physician { get; set; }
        public ICollection<Responsibility> Responsibilities { get; set; }

        public Teacher(int id, string firstName, string lastName, string position, string uCN)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be less than zero");
            }
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            UCN = uCN;
        }

        public Teacher(int id, string firstName, string lastName, decimal salary, string phoneNumber, string email, string position, string uCN)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be less than zero");
            }
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
            UCN = uCN;
        }
    }
}
