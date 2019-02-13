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

        public Period(int id, string subject)
        {
            if (id <0)
            {
                throw new ArgumentException("Id cannot be less than zero");
            }
            Id = id;
            Subject = subject;
        }

        public Period(int id, string subject, DateTime startTime, DateTime endTime) : this(id, subject)
        {
            if (startTime == null)
            {
                throw new ArgumentException("StartTime cannot be null");
            }
            if (endTime == null)
            {
                throw new ArgumentException("EndTime cannot be null");
            }
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
