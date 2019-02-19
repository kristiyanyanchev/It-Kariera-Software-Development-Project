using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Student : IStudent
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

        public IClass Class { get; set; }
        public IPhysician Physician { get; set; }

        public ICollection<IParent> Parents { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, bool inAbsentia, string uCN)
        {
            if(firstName == null)
            {
                throw new ArgumentNullException("FirstName cannot be null");
            }
            if (lastName == null)
            {
                throw new ArgumentNullException("LastName cannot be null");
            }
            if (uCN == null)
            {
                throw new ArgumentNullException("UCN cannot be null");
            }
            if (DateTime.Compare(birthDate,new DateTime(1900,1,1)) < 0)
            {
                throw new ArgumentException("BirthDate cannot be before 1900");
            }

            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            InAbsentia = inAbsentia;
            UCN = uCN;
            Parents = new List<IParent>();
        }


        
    }
}
