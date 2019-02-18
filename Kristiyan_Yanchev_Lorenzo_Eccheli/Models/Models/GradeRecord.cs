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

        public GradeRecord(double grade, DateTime date, Student student)
        {
            Grade = grade;
            Date = date;
            Student = student;
        }
    }
}
