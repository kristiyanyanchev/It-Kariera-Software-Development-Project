using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Absences
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsLate { get; set; }
        public Student Student { get; set; }
        public Period Period { get; set; }

        public Absences(int id, bool isLate, Student student, Period period)
        {
            if (id <0)
            {
                throw new ArgumentException("Id cannot be less than zero");
            }
            Id = id;
            IsLate = isLate;
            Student = student;
            Period = period;
        }
    }
}
