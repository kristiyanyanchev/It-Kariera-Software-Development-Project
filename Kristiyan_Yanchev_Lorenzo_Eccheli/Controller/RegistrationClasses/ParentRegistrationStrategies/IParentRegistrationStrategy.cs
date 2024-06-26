﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses.ParentRegistrationStrategies
{
    interface IParentRegistrationStrategy
    {
        Parent Execute(ParentDataTransferObject parentDto);
    }
}
