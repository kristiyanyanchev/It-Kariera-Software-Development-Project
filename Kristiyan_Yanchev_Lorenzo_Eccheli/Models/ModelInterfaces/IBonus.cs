using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.ModelInterfaces
{
    public interface IBonus
    {
        int Id { get; set; }
        decimal Amount { get; set; }
        string Description { get; set; }
    }
}
