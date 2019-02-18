﻿using System;
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
        [Required,MaxLength(3),MinLength(2)]
        public string ClassName { get; set; }

        public Teacher Teacher { get; set; }

        public Class(string className, Teacher teacher)
        {
            ClassName = className;
            Teacher = teacher;
        }
    }
}
