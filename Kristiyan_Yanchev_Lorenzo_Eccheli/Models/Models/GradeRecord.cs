using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class GradeRecord : IGradeRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Grade { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public IStudent Student { get; set; }

        public GradeRecord(double grade, DateTime date, IStudent student)
        {
            if (grade < 0)
            {
                throw new ArgumentException("Grade cannot be less than zero.");
            }
            if (DateTime.Compare(date,new DateTime(1900,1,1)) < 0)
            {
                throw new ArgumentException("Date cannot be before 1900.01.01");
            }
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }
            Grade = grade;
            Date = date;
            Student = student;
        }
    }
}
