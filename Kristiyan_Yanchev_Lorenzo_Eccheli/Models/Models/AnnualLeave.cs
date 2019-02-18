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

        public AnnualLeave(DateTime startDate, DateTime endDate, Teacher teacher)
        {
            StartDate = startDate;
            EndDate = endDate;
            Teacher = teacher;
        }
    }
}
