using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class GradeRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Grade { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Student Student { get; set; }

        public GradeRecord(int id, double grade, DateTime date, Student student)
        {
            if (id<0)
            {
                throw new ArgumentException("Id should be more than zero");
            }
            if (date == null)
            {
                throw new ArgumentException("Date cannot be null");
            }
            if (student == null)
            {
                throw new ArgumentException("Student cannot be null");
            }
            if (grade < 1)
            {
                throw new ArgumentException("Grade cannot be less than 1");
            }
            Id = id;
            Grade = grade;
            Date = date;
            Student = student;
        }
    }
}
