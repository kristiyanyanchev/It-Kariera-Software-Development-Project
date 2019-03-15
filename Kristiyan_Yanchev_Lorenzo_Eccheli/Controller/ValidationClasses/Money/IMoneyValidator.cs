using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.Money
{
    public interface IMoneyValidator
    {
        bool Validate(string money);
    }
}
