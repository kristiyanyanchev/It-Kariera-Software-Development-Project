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
        public string Name { get; set; }

        public Teacher Teacher { get; set; }
    }
}
