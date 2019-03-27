using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }
        public Student Student { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public DateTime Period { get; set; }
        [Required]
        public bool IsLate { get; set; }

        public override string ToString()
        {
            return string.Format("{0} => {1},{2}", StudentId, Period, IsLate);
        }

        public Absence()
        {

        }

        public Absence(int studentId, DateTime period, bool isLate)
        {

            StudentId = studentId;
            Period = period;
            IsLate = isLate;
        }
    }
}
