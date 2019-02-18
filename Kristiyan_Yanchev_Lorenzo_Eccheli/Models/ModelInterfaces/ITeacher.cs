using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface ITeacher
    {  
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; } 
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Position { get; set; }
        string UCN { get; set; }
    }
}
