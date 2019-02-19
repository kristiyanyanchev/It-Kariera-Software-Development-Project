using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Responsibility : IResponsibility
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ITeacher> Teachers { get; set; }

        public Responsibility(string name, string description)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if (description== null)
            {
                throw new ArgumentNullException("Description cannot be null");
            }
            Name = name;
            Description = description;
            Teachers = new List<ITeacher>();
        }
    }
}
