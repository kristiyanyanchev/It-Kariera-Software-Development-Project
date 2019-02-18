using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IAbsence
    {
        int Id { get; set; }
        bool IsLate { get; set; }
        


    }
}
