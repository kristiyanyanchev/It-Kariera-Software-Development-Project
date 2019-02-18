using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Responsibility
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public Responsibility(string name, string description)
        {
            Name = name;
            Description = description;
            Teachers = new List<Teacher>();
        }
    }
}
