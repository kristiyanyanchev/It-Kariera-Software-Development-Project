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

        private IStudent student;

        public virtual IStudent Student
        {
            get { return student; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student cannot be null.");
                }
                student = value;
            }
        }

        private IPeriod period;

        public virtual IPeriod Period
        {
            get { return period; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Period cannot be null.");
                }
                period = value;
            }
        }

        public Absence()
        {

        }

        public Absence(bool isLate, IStudent student, IPeriod period)
        {
            
            IsLate = isLate;
            Student = student;
            Period = period;
        }
    }
}
