﻿using Controller.ValidationClasses.Address;
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
    /// <summary>
    /// Provides Validation for Parent class
    /// </summary>
    public class ParentValidator
    {
        internal IUsernameValidator UsernameValidator { get; set; }
        internal INameValidator FirstNameValidator { get; set; }
        internal INameValidator LastNameValidator { get; set; }
        internal IPasswordValidator PasswordValidator { get; set; }
        internal IEmailValidator EmailValidator { get; set; }
        internal IAddressValidator AddressValidator { get; set; }
        internal IPhoneNumberValidator PhoneNumberValidator { get; set; }
        internal IValidationCodeValidator ValidationCodeValidator { get; set; }
        internal IUsernameValidator UsernameOfChildValidator { get; set; }

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

        /// <summary>
        /// Provides validation for parent class via parentDto
        /// </summary>
        /// <param name="parentDTO"></param>
        /// <returns>The value should be showed to the user</returns>
        public string ValidateParent(ParentDataTransferObject parentDTO)
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
            if (validationCodes.List().Single(x => x.Code == parentDTO.ValidationCode).Role != "Parent")
            {
                return "ValidationCode Role is not Parent! ";
            }

            if (UsernameOfChildValidator.Validate(parentDTO.UsernameOfChild) == false)
            {
                return "UsernameOfChild error!";
            }
            if (students.List().Select(x => x.Username).Contains(parentDTO.UsernameOfChild) == false)
            {
                return "Username of Child does not exist!";
            }

            return "Registration Successful! ";
        }
    }
}
