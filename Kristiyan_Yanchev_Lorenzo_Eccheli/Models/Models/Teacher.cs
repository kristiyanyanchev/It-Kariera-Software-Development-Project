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

        public Teacher(string firstName, string lastName, decimal salary, string position, string uCN)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Position = position;
            UCN = uCN;
            Responsibilities = new List<Responsibility>();
        }
    }
}
