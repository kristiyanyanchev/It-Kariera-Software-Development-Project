using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IPeriod
    {
        int Id { get; set; }
        string Subject { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
    }
}
