using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Teacher Teacher { get; set; }

        public Class()
        {

        }

        public Class(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
        }
    }
}
