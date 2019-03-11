using Controller.ValidationClasses.PhoneNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Tests.ValidationClasses.PhoneNumber
{
    [TestFixture]
    public class DefaultPhoneNumberValidatorTest
    {
        [TestCase("12345678901")]
        [TestCase("123456789")]
        public void Validate_LengthLessOrGreaterThanRequired_ReturnsFalse(string number)
        {
            var validator = new DefaultPhoneNumberValidator();
            Assert.False(validator.Validate(number));
        }

        [TestCase("123456789o")]
        [TestCase("123456789@")]
        [TestCase("123-456-7890")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string number)
        {
            var validator = new DefaultPhoneNumberValidator();
            Assert.False(validator.Validate(number));
        }

    }
}
