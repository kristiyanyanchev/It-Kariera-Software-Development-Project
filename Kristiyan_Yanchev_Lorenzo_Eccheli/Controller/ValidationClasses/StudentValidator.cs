using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controller.ValidationClasses.Username;
using Controller.ValidationClasses.FirstNameAndLastName;
using Controller.ValidationClasses.Password;
using Controller.ValidationClasses.Email;
using Controller.ValidationClasses.ValidationCode;
using Controller.ValidationClasses.Address;
using Controller.ValidationClasses.PhoneNumber;
using Data.Repositories;
using Controller.ValidationClasses.Class;
using Controller.ValidationClasses.UCN;

namespace Controller.ValidationClasses
{
    class StudentValidator
    {
        public IUsernameValidator UsernameValidator { get; set; }
        public INameValidator FirstNameValidator { get; set; }
        public INameValidator LastNameValidator { get; set; }
        public IPasswordValidator PasswordValidator { get; set; }
        public IEmailValidator EmailValidator { get; set; }
        public IValidationCodeValidator ValidationCodeValidator { get; set; }
        public IAddressValidator AddressValidator { get; set; }
        public IPhoneNumberValidator PhoneNumberValidator { get; set; }
        public IClassValidator ClassValidator { get; set; }
        public IUcnValidator UcnValidator { get; set; }

        public string ValidateStudent(StudentDataTransferObject studentDTO)
        {
            var validationCodeRepo = new ValidationCodeRepository();
            var students = new StudentsRepository();
            var classes = new ClassesRepository();
            var teachers = new TeachersRepository();
            var parents = new ParentsRepository();
            if (UsernameValidator.Validate(studentDTO.Username) == false)
            {
                return "Username error! ";
            }

            if (students.List().Select(x => x.Username).Contains(studentDTO.Username) == true ||
                teachers.List().Select(x => x.Username).Contains(studentDTO.Username) == true ||
                parents.List().Select(x => x.Username).Contains(studentDTO.Username) == true)
            {
                return "This Username alredy exist!";
            }

            if (FirstNameValidator.Validate(studentDTO.FirstName) == false)
            {
                return "First name error! ";
            }

            if (LastNameValidator.Validate(studentDTO.LastName) == false)
            {
                return "Last name error! ";
            }

            if (PasswordValidator.Validate(studentDTO.Password) == false)
            {
                return "Password error! ";
            }

            if (EmailValidator.Validate(studentDTO.Email) == false)
            {
                return "Email error! ";
            }

            if (ValidationCodeValidator.Validate(studentDTO.ValidationCode) == false)
            {
                return "ValidationCode error! ";
            }

            if (validationCodeRepo.List().Select(x => x.Code).Contains(studentDTO.ValidationCode) == false)
            {
                return "ValidationCode is not valid!";
            }

            if (validationCodeRepo.List().Single(x => x.Code == studentDTO.ValidationCode).Used == true)
            {
                return "ValidationCode is alredey used";
            }

            if (AddressValidator.Validate(studentDTO.Address) == false)
            {
                return "Address error! ";
            }

            if (PhoneNumberValidator.Validate(studentDTO.PhoneNumber) == false)
            {
                return "Phone number error! ";
            }

            if (ClassValidator.Validate(studentDTO.Class) == false)
            {
                return "Class error! ";
            }

            if (UcnValidator.Validate(studentDTO.Ucn) == false)
            {
                return "Ucn error! ";
            }

            if (students.List().Select(x => x.Ucn).Contains(studentDTO.Ucn) == true)
            {
                return "Ucn alredy used! ";
            }

            if (studentDTO.BirthDate.CompareTo(DateTime.Now) >= 0)
            {
                return "Student is too young! ";
            }

            return "Successful Registration! ";
        }

        public StudentValidator()
        {
            UsernameValidator = new DefaultUsernameValidator();
            FirstNameValidator = new DefaultNameValidator();
            LastNameValidator = new DefaultNameValidator();
            PasswordValidator = new DefaultPasswordValidator();
            EmailValidator = new DefaultEmailValidator();
            ValidationCodeValidator = new DefaultValidationCodeValidator();
            AddressValidator = new DefaultAddressValidator();
            PhoneNumberValidator = new DefaultPhoneNumberValidator();
            ClassValidator = new DefaultClassValidator();
            UcnValidator = new DefaultUcnValidator();
        }

    }
}
