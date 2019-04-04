using Controller.RegistrationClasses.StudentRegistrationStrategies;
using Controller.ValidationClasses;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses
{
    public class StudentRegistration
    {
        internal IStudentRegistrationStrategy RegistrationStrategy { get; set; }

        public Student Register(StudentDataTransferObject studentDto)
        {
           return RegistrationStrategy.Execute(studentDto);
           
        }

        public StudentRegistration()
        {
            RegistrationStrategy = new DefaultStudentRegistration();
        }
    }
}
