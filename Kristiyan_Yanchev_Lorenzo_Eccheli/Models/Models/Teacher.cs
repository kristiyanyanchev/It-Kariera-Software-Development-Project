using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Teacher : ITeacher
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

        public IPhysician Physician { get; set; }
        public ICollection<IResponsibility> Responsibilities { get; set; }

        public Teacher(string firstName, string lastName, decimal salary, string position, string uCN)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("FirstName cannot be null.");
            }
            if (lastName == null)
            {
                throw new ArgumentNullException("LastName cannot be null.");
            }
            if (salary < 0)
            {
                throw new ArgumentException("Salary must be positive number.");
            }
            if (position == null)
            {
                throw new ArgumentNullException("Position cannot be null.");
            }
            if (uCN == null)
            {
                throw new ArgumentNullException("UCN cannot be null.");
            }
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Position = position;
            UCN = uCN;
            Responsibilities = new List<IResponsibility>();
        }
    }
}
