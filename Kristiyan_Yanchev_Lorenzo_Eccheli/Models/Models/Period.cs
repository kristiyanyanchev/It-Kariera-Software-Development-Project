using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Period : IPeriod
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        public ITeacher Teacher { get; set; }
        public IClass Class { get; set; }

        public Period(string subject, DateTime startTime, DateTime endTime, ITeacher teacher, IClass @class)
        {
            if (subject == null)
            {
                throw new ArgumentNullException("Subject cannot be null.");
            }
            if (DateTime.Compare(startTime, new DateTime(1900, 1, 1)) < 0)
            {
                throw new ArgumentException("StartTime canot be before 1900.1.1");
            }
            if (DateTime.Compare(endTime, new DateTime(1900, 1, 2)) < 0)
            {
                throw new ArgumentException("EndTime canot be before 1900.1.2");
            }
            if (DateTime.Compare(startTime,endTime) > 0)
            {
                throw new ArgumentException("StartTime Cannot be after EndTime.");
            }
            if (teacher == null)
            {
                throw new ArgumentNullException("Teacher cannot be null.");
            }
            if (@class == null)
            {
                throw new ArgumentNullException("Class cannot be null.");
            }

            Subject = subject;
            StartTime = startTime;
            EndTime = endTime;
            Teacher = teacher;
            Class = @class;
        }
    }
}
