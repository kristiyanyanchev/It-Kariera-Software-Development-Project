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
        public string Ucn { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }


        [Required]
        public string ValidationCode { get; set; }

        public Class Class { get; set; }
        public int? ClassId { get; set; }

        public ICollection<Parent> Parents { get; set; }
        public ICollection<Absence> Absences { get; set; }
        public ICollection<GradeRecord> GradeRecords { get; set; }

        public Student()
        {
            Parents = new List<Parent>();
            Absences = new List<Absence>();
            GradeRecords = new List<GradeRecord>();
        }

        public Student(string firstName, string lastName, DateTime birthDate, bool inAbsentia, string address, string validationCode)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            InAbsentia = inAbsentia;
            Address = address;
            ValidationCode = validationCode;
            Parents = new List<Parent>();
            Absences = new List<Absence>();
            GradeRecords = new List<GradeRecord>();
        }

        public Student(string firstName, string lastName, DateTime birthDate, string address, string ucn, string phoneNumber,
            string email, string username, string password, string validationCode, Class @class)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Ucn = ucn;
            PhoneNumber = phoneNumber;
            Email = email;
            Username = username;
            Password = password;
            ValidationCode = validationCode;
            Class = @class;
            Parents = new List<Parent>();
            Absences = new List<Absence>();
            GradeRecords = new List<GradeRecord>();
        }
        public Student(string firstName, string lastName, DateTime birthDate, string address, string ucn, string phoneNumber,
            string email, string username, string password, string validationCode, int classId)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Ucn = ucn;
            PhoneNumber = phoneNumber;
            Email = email;
            Username = username;
            Password = password;
            ValidationCode = validationCode;
            ClassId = classId;
            Parents = new List<Parent>();
            Absences = new List<Absence>();
            GradeRecords = new List<GradeRecord>();
        }

        public override string ToString()
        {
            return Id + " " + FirstName + " " + LastName;
        }

    }
}
