using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface ISickLeave
    {
        int Id { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
