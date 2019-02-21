using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Class : IClass
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(3),MinLength(2)]
        public string ClassName { get; set; }

        public ITeacher Teacher { get; set; }

        public Class(string className, ITeacher teacher)
        {
            if (className == null)
            {
                throw new ArgumentNullException("ClassName cannot be null");
            }
            if (teacher == null)
            {
                throw new ArgumentNullException("Teacher cannot be null");
            }
            ClassName = className;
            Teacher = teacher;
        }
    }
}
