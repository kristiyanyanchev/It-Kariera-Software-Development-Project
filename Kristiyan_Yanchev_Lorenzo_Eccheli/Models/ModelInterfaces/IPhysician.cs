using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IPhysician
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
    }
}
