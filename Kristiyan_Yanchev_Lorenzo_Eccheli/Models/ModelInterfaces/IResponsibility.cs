using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IResponsibility
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
