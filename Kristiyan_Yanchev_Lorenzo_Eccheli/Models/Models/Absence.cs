using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        public Period Period { get; set; }
        [Required]
        public bool IsLate { get; set; }

    }
}
