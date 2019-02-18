using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Period
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        public Teacher Teacher { get; set; }
        public Class Class { get; set; }

        public Period(string subject, DateTime startTime, DateTime endTime, Teacher teacher, Class @class)
        {
            Subject = subject;
            StartTime = startTime;
            EndTime = endTime;
            Teacher = teacher;
            Class = @class;
        }
    }
}
