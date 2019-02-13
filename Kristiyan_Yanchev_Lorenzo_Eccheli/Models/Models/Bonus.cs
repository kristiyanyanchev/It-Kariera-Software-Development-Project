using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Bonus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Description { get; set; }
        public Teacher Teacher { get; set; }

        public Bonus(int id, decimal amount, string description)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be less than zero");
            }
            if (amount <=0)
            {
                throw new ArgumentException("Amount most be more than zero");
            }
            Id = id;
            Amount = amount;
            Description = description;
        }
    }
}
