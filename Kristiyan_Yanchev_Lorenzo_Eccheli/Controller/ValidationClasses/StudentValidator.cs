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
    public class StudentValidator
    {
        internal IUsernameValidator UsernameValidator { get; set; }
        internal INameValidator FirstNameValidator { get; set; }
        internal INameValidator LastNameValidator { get; set; }
        internal IPasswordValidator PasswordValidator { get; set; }
        internal IEmailValidator EmailValidator { get; set; }
        internal IValidationCodeValidator ValidationCodeValidator { get; set; }
        internal IAddressValidator AddressValidator { get; set; }
        internal IPhoneNumberValidator PhoneNumberValidator { get; set; }
        internal IClassValidator ClassValidator { get; set; }
        internal IUcnValidator UcnValidator { get; set; }

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
                return "ValidationCode is not valid! ";
            }

            if (validationCodeRepo.List().Single(x => x.Code == studentDTO.ValidationCode).Used == true)
            {
                return "ValidationCode is alredey used! ";
            }
            if (validationCodeRepo.List().Single(x => x.Code == studentDTO.ValidationCode).Role != "Student")
            {
                return "ValidationCode Role is not Student! ";
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
            if (classes.List().Select(x => x.Name).Contains(studentDTO.Class) == false)
            {
                return "Class Does not exist! ";
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
