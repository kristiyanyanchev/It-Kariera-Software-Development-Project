using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class ValidationCode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Role { get; set; }
        public bool Used { get; set; }

        public ValidationCode()
        {
            
        }

        public ValidationCode(string code, string role)
        {
            Code = code;
            Role = role;
        }
    }
}
