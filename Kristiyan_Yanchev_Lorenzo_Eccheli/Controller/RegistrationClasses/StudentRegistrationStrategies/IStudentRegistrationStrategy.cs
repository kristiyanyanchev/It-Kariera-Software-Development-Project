using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses.StudentRegistrationStrategies
{
    interface IStudentRegistrationStrategy
    {
        Student Execute(StudentDataTransferObject dto);
    }
}
