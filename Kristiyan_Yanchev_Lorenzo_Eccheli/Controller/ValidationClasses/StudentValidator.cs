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

    }
}
