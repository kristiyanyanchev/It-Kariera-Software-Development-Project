﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.Email
{
    interface IEmailValidator
    {
        bool Validate(string email);
    }
}
