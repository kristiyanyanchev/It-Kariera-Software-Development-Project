using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        


        public ICollection<Student> Students { get; set; }

        public Class()
        {

        }

        public Class(string name)
        {
            Name = name;
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
