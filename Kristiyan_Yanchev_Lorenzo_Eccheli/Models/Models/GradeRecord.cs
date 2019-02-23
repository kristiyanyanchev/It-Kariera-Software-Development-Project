using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class GradeRecord
    {
        [Key]
        public int Id { get; set; }
        public double Grade { get; set; }
        public DateTime Date { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }

    }
}
