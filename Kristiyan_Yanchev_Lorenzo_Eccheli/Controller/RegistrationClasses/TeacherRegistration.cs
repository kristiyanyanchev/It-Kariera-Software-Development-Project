using Controller.RegistrationClasses.TeacherRegitrationStrategies;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses
{
    public class TeacherRegistration
    {
        internal ITeacherRegistrationStrategy RegistrationStrategy { get; set; }
        public Teacher Register(TeacherDataTransferObject Dto)
        {
            return RegistrationStrategy.Execute(Dto);
        }

        public TeacherRegistration()
        {
            RegistrationStrategy = new DefaultTeacherRegistration();

        }

        
    }
}
