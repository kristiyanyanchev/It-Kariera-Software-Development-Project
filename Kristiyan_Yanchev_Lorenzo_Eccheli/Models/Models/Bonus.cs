﻿using Data.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Bonus : IBonus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Description { get; set; }
        public ITeacher Teacher { get; set; }

        public Bonus(decimal amount, string description, ITeacher teacher)
        {
            Amount = amount;
            Description = description;
            Teacher = teacher;
        }
    }
}
