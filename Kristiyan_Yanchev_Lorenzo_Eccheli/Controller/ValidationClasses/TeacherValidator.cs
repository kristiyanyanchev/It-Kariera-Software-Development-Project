using Controller.ValidationClasses.Username;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controller.ValidationClasses.FirstNameAndLastName;
using Controller.ValidationClasses.Password;
using Controller.ValidationClasses.Email;
using Controller.ValidationClasses.Address;
using Controller.ValidationClasses.PhoneNumber;
using Controller.ValidationClasses.ValidationCode;
using Controller.ValidationClasses.Class;
using Data.Repositories;

namespace Controller.ValidationClasses
{
    class TeacherValidator
    {
        public IUsernameValidator UsernameValidator { get; set; }
        public INameValidator FirstNameValidator { get; set; }
        public INameValidator LastNameValidator { get; set; }
        public IPasswordValidator PasswordValidator { get; set; }
        public IEmailValidator EmailValidator { get; set; }
        public IAddressValidator AddressValidator { get; set; }
        public IPhoneNumberValidator PhoneNumberValidator { get; set; }
        public IValidationCodeValidator ValidationCodeValidator { get; set; }
        public IClassValidator ClassValidator { get; set; }

        public TeacherValidator()
        {
            UsernameValidator = new DefaultUsernameValidator();
            FirstNameValidator = new DefaultNameValidator();
            LastNameValidator = new DefaultNameValidator();
            PasswordValidator = new DefaultPasswordValidator();
            EmailValidator = new DefaultEmailValidator();
            AddressValidator = new DefaultAddressValidator();
            PhoneNumberValidator = new DefaultPhoneNumberValidator();
            ValidationCodeValidator = new DefaultValidationCodeValidator();
            ClassValidator = new DefaultClassValidator();
        }

        public string ValidateTeacher(TeacherDataTransferObject teacherDTO)
        {
            var validationCodeRepo = new ValidationCodeRepository();
            var teacherRepo = new TeachersRepository();
            var studentsRepo = new StudentsRepository();
            var parents = new ParentsRepository();
            var classes = new ClassesRepository();
            if (UsernameValidator.Validate(teacherDTO.Username) == false)
            {
                return "Username error! ";
            }

            if (studentsRepo.List().Select(x => x.Username).Contains(teacherDTO.Username) == true ||
               teacherRepo.List().Select(x => x.Username).Contains(teacherDTO.Username) == true ||
               parents.List().Select(x => x.Username).Contains(teacherDTO.Username) == true )
            {
                return "This Username alredy exist!";
            }

            if (FirstNameValidator.Validate(teacherDTO.FirstName) == false)
            {
                return "FirstName error! ";
            }

            if (LastNameValidator.Validate(teacherDTO.LastName) == false)
            {
                return "LastName error! ";
            }

            if (PasswordValidator.Validate(teacherDTO.Password) == false)
            {
                return "Password error! ";
            }

            if (EmailValidator.Validate(teacherDTO.Email) == false)
            {
                return "Email error!";
            }

            if (AddressValidator.Validate(teacherDTO.Address) == false)
            {
                return "Address error!";
            }
            if (ValidationCodeValidator.Validate(teacherDTO.ValidationCode) == false)
            {
                return "ValidtationCode error!";
            }

            if (validationCodeRepo.List().Single(x => x.Code == teacherDTO.ValidationCode).Used == true)
	        {
		        return "ValidationCode is alredy used!";
	        }

            if (PhoneNumberValidator.Validate(teacherDTO.PhoneNumber) == false)
            {
                return "PhoneNumber error!";
            }
            if (ClassValidator.Validate(teacherDTO.Class) == false)
            {
                return "Class error";
            }
            if (classes.List().Select(x => x.Name).Contains(teacherDTO.Class) == false)
            {
                return "Class does not exist";
            }

            return "Registration successful";
        }
    }
}
