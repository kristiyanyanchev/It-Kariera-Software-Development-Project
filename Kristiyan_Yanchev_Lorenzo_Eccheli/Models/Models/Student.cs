using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(30),MinLength(2)]
        public string FirstName { get; set; }

        [Required, MaxLength(255), MinLength(2)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool InAbsentia { get; set; }

        public decimal? Scholarships { get; set; }

        [Required,Index(IsUnique =true),MaxLength(10),MinLength(10)]
        public string UCN { get; set; }

        [MaxLength(10),MinLength(10)]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public Class Class { get; set; }
        public Physician Physician { get; set; }

        public ICollection<Parent> Parents { get; set; }

        public Student(int id, string firstName, string lastName, DateTime birthDate, bool inAbsentia, string ucn)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id should be more than zero ");
            }
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            InAbsentia = inAbsentia;
            UCN = ucn;
        }

        public Student(int id, string firstName, string lastName, DateTime birthDate, bool inAbsentia, string ucn, string phoneNumber) : this(id, firstName, lastName, birthDate, inAbsentia, ucn)
        {
            PhoneNumber = phoneNumber;
        }

        public Student(int id, string firstName, string lastName, DateTime birthDate, bool inAbsentia, string ucn, string phoneNumber, string email) : this(id, firstName, lastName, birthDate, inAbsentia, ucn, phoneNumber)
        {
            Email = email;
        }
    }
}
