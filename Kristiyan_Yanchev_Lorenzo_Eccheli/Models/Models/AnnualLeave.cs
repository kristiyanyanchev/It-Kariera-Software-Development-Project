using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class AnnualLeave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public Teacher Teacher { get; set; }

        public AnnualLeave(int id, DateTime startDate, DateTime endDate)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be less than zero");
            }
            if (startDate == null)
            {
                throw new ArgumentException("StartTime cannot be null");
            }
            if (endDate == null)
            {
                throw new ArgumentException("EndTime cannot be null");
            }
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
