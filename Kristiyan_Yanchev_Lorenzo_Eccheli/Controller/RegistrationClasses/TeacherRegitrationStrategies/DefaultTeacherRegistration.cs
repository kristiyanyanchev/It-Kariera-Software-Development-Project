using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace Controller.RegistrationClasses.TeacherRegitrationStrategies
{
    class DefaultTeacherRegistration : ITeacherRegistrationStrategy
    {
        public Teacher Execute(TeacherDataTransferObject teacherDto)
        {
            var teacherRepo = new TeachersRepository();

            var teacher = new Teacher(teacherDto.FirstName, teacherDto.LastName, teacherDto.Subject, teacherDto.PhoneNumber,
                            teacherDto.Email, teacherDto.Position, teacherDto.Username, teacherDto.Password, teacherDto.ValidationCode, teacherDto.Address);

            if (teacherDto.Class == "none")
            {
                teacher.Class = null;
            }
            else
            {

                teacher.Class = new Class(teacherDto.Class);
            }

            teacherRepo.Add(teacher);

            var validationCodes = new ValidationCodeRepository();
            var currentValidationCode = validationCodes.List().Single(x => x.Code == teacherDto.ValidationCode);
            currentValidationCode.Used = true;
            validationCodes.Edit(currentValidationCode);

            return teacher;
        }
    }
}
