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
        [Required]
        public Student Student { get; set; }
        public int StudentId { get; set; }
        [Required]
        public DateTime Period { get; set; }
        [Required]
        public bool IsLate { get; set; }


    }
}
