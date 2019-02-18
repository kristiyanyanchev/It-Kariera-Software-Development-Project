using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IStudent
    {
        
        int Id { get; set; }        
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        bool InAbsentia { get; set; }
        decimal? Scholarships { get; set; }      
        string UCN { get; set; }
        string PhoneNumber { get; set; }

        string Email { get; set; }
    }
}
