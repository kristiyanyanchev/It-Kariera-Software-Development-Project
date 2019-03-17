using Controller.ValidationClasses.Address;
using Controller.ValidationClasses.Email;
using Controller.ValidationClasses.FirstNameAndLastName;
using Controller.ValidationClasses.Password;
using Controller.ValidationClasses.PhoneNumber;
using Controller.ValidationClasses.Username;
using Controller.ValidationClasses.ValidationCode;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses
{
    class ParentValidator
    {
        public IUsernameValidator UsernameValidator { get; set; }
        public INameValidator FirstNameValidator { get; set; }
        public INameValidator LastNameValidator { get; set; }
        public IPasswordValidator PasswordValidator { get; set; }
        public IEmailValidator EmailValidator { get; set; }
        public IAddressValidator AddressValidator { get; set; }
        public IPhoneNumberValidator PhoneNumberValidator { get; set; }
        public IValidationCodeValidator ValidationCodeValidator { get; set; }
        public IUsernameValidator UsernameOfChildValidator { get; set; }

        public ParentValidator()
        {
            UsernameValidator = new DefaultUsernameValidator();
            FirstNameValidator = new DefaultNameValidator();
            LastNameValidator = new DefaultNameValidator();
            PasswordValidator = new DefaultPasswordValidator();
            EmailValidator = new DefaultEmailValidator();
            AddressValidator = new DefaultAddressValidator();
            PhoneNumberValidator = new DefaultPhoneNumberValidator();
            ValidationCodeValidator = new DefaultValidationCodeValidator();
            UsernameOfChildValidator = new DefaultUsernameValidator();
        }

        string ValidateParent(ParentDataTransferObject parentDTO)
        {
            var students = new StudentsRepository();
            var parents = new ParentsRepository();
            var teachers = new TeachersRepository();
            var validationCodes = new ValidationCodeRepository();
            if (UsernameValidator.Validate(parentDTO.Username) == false)
            {
                return "Username error! ";
            }

            if (students.List().Select(x => x.Username).Contains(parentDTO.Username) == true || 
                parents.List().Select(x => x.Username).Contains(parentDTO.Username) == true ||
                teachers.List().Select(x => x.Username).Contains(parentDTO.Username) == true)
            {
                return "Username is alredy used! ";
            }

            if (FirstNameValidator.Validate(parentDTO.FirstName) == false)
            {
                return "FirstName error! ";
            }

            if (LastNameValidator.Validate(parentDTO.LastName) == false)
            {
                return "LastName error! ";
            }

            if (PasswordValidator.Validate(parentDTO.Password) == false)
            {
                return "Password error! ";
            }

            if (EmailValidator.Validate(parentDTO.Email) == false)
            {
                return "Email error! ";
            }

            if (AddressValidator.Validate(parentDTO.Address) == false)
            {
                return "Address error! ";
            }

            if (PhoneNumberValidator.Validate(parentDTO.PhoneNumber) == false)
            {
                return "PhoneNumber error! ";
            }

            if (ValidationCodeValidator.Validate(parentDTO.ValidationCode) == false)
            {
                return "ValidationCode error! ";
            }

            if (validationCodes.List().Single(x => x.Code == parentDTO.ValidationCode).Used == true)
            {
                return "ValidationCode is alredy used!";
            }

            if (UsernameOfChildValidator.Validate(parentDTO.UsernameOfChild) == false)
            {
                return "UsernameOfChild error!";
            }
            if (students.List().Select(x => x.Username).Contains(parentDTO.UsernameOfChild) == false)
            {
                return "Username of Child does not exist!";
            }

            return "Registration Successful!";
        }
    }
}
