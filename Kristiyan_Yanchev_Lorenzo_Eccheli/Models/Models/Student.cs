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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public bool InAbsentia { get; set; }
        [Required]
        public string Address { get; set; }
        public decimal? Schoolarship { get; set; }
        public string Ucn { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

       

        [Required]
        public string ValidationCode { get; set; }

        public Class Class { get; set; }

        public ICollection<Parent> Parents { get; set; }
        public ICollection<Absence> Absences { get; set; }
        public ICollection<GradeRecord> GradeRecords { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, DateTime birthDate, bool inAbsentia, string address, string validationCode)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            InAbsentia = inAbsentia;
            Address = address;
            ValidationCode = validationCode;
        }

        public Student(string firstname,string lastname,DateTime birthdate,string address,string ucn,string phonenumber,string email, string validationCode)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Address = address;
            Ucn = ucn;
            PhoneNumber = phonenumber;
            Email = email;
            ValidationCode = validationCode;
        }

        public void AddScholarship(decimal scolarship)
        {
            Schoolarship = scolarship;
        }

    }
}
