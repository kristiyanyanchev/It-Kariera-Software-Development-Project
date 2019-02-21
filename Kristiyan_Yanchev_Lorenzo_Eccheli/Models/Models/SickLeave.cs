using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class SickLeave : ISickLeave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public ITeacher Teacher { get; set; }

        public SickLeave(DateTime startDate, DateTime endDate, ITeacher teacher)
        {
            if (DateTime.Compare(startDate,new DateTime(1900,1,1))<0)
            {
                throw new ArgumentException("StartDate cannot be before 1900.1.1");
            }
            if (DateTime.Compare(startDate, new DateTime(1900, 1, 2)) < 0)
            {
                throw new ArgumentException("EndDate cannot be before 1900.1.2");
            }
            if (DateTime.Compare(startDate,endDate) > 0)
            {
                throw new ArgumentException("StartDate cannot be after EndDate");
            }
            if (teacher == null)
            {
                throw new ArgumentNullException("Teacher cannot be null");
            }
            StartDate = startDate;
            EndDate = endDate;
            Teacher = teacher;
        }
    }
}
