using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class AnnualLeave : IAnnualLeave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public ITeacher Teacher { get; set; }

        public AnnualLeave(DateTime startDate, DateTime endDate, ITeacher teacher)
        {
            if (DateTime.Compare(startDate, new DateTime(1900, 1, 1)) <0)
            {
                throw new ArgumentException("StartDate cannot be before 1900.01.01");
            }

            if (DateTime.Compare(endDate,new DateTime(1900,1,2))<0)
            {
                throw new ArgumentException("EndDate cannot be before 1900.01.02");
            }

            if (DateTime.Compare(startDate,endDate) > 0)
            {
                throw new ArgumentException("StartDate cannot be before EndDate");
            }

            StartDate = startDate;
            EndDate = endDate;
            Teacher = teacher;
        }
    }
}
