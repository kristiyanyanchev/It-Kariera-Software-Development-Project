using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Absence : IAbsence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsLate { get; set; }

        private Student student;

        public Student Student
        {
            get { return student; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Student cannot be null.");
                }
                student = value;
            }
        }

        private Period period;

        public Period Period
        {
            get { return period; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Period cannot be null.");
                }
                period = value;
            }
        }


        public Absence(bool isLate, Student student, Period period)
        {
            IsLate = isLate;
            Student = student;
            Period = period;
        }
    }
}
