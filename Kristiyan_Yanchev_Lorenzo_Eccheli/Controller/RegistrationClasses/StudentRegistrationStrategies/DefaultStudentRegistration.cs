using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses;
using Data.Models;
using Data.Repositories;

namespace Controller.RegistrationClasses.StudentRegistrationStrategies
{
    class DefaultStudentRegistration : IStudentRegistrationStrategy
    {
        public Student Execute(StudentDataTransferObject studentDto)
        {
            var classes = new ClassesRepository();
            var studentsRepo = new StudentsRepository();
            var studentValidator = new StudentValidator();

            var studentClass = classes.List().Single(x => x.Name == studentDto.Class).Id;

            Student student = new Student(studentDto.FirstName, studentDto.LastName, studentDto.BirthDate,
                studentDto.Address, studentDto.Ucn, studentDto.PhoneNumber, studentDto.Email, studentDto.Username,
                studentDto.Password, studentDto.ValidationCode, studentClass);

            studentsRepo.Add(student);

            var validationCodes = new ValidationCodeRepository();
            var currentValidationCode = validationCodes.List().Single(x => x.Code == studentDto.ValidationCode);
            currentValidationCode.Used = true;
            validationCodes.Edit(currentValidationCode);
            return student;
        }
    }
}
