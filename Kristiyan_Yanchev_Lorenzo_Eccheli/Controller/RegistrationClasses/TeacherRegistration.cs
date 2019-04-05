using Controller.RegistrationClasses.TeacherRegitrationStrategies;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses
{
    /// <summary>
    /// Provides different registration strategies.
    /// </summary>
    public class TeacherRegistration
    {
        internal ITeacherRegistrationStrategy RegistrationStrategy { get; set; }

        /// <summary>
        /// Transforms TeacherDto to Teacher.
        /// </summary>
        /// <param name="Dto"></param>
        /// <returns></returns>
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
