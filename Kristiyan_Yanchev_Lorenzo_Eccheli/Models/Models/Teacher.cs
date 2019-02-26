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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Ucn { get; set; }

        public Physician Physician { get; set; }
        public ICollection<Subject> Subjects { get; set; }

    }
}
