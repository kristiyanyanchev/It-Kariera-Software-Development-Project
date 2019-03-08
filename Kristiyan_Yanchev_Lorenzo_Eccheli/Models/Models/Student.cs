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
        public Physician Physician { get; set; }

        public ICollection<Parent> Parents { get; set; }
        public ICollection<Subject> Subjects { get; set; }

        public Student(string firstname,string lastname,DateTime birthdate,string address,string ucn,string phonenumber,string email)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Address = address;
            Ucn = ucn;
            PhoneNumber = phonenumber;
            Email = email;
        }

        public void AddScholarship(decimal scolarship)
        {
            Schoolarship = scolarship;
        }

    }
}
