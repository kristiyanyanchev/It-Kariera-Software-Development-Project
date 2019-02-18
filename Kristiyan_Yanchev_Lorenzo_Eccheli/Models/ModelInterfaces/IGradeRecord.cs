using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IGradeRecord
    {
        int Id { get; set; }
        double Grade { get; set; }
        DateTime Date { get; set; }
    }
}
