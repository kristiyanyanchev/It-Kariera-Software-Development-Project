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

        public string ValidateStudent(StudentDataTransferObject studentDTO)
        {
            var validationCodeRepo = new ValidationCodeRepository();
            var studentsRepo = new StudentsRepository();
            if (UsernameValidator.Validate(studentDTO.Username) == false)
            {
                return "Username error! ";
            }

            if (studentsRepo.List().Select(x => x.Username).Contains(studentDTO.Username) == true)
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

            return "Successful Registration";
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
        }

    }
}
