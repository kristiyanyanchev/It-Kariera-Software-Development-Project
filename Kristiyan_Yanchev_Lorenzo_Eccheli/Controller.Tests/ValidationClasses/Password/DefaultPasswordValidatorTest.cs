using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses.Password;

namespace Controller.Tests.ValidationClasses.Password
{
    [TestFixture]
    public class DefaultPasswordValidatorTest
    {
        
        [TestCase ("aboo123")]
        [TestCase ("12345")]
        [TestCase ("@!#")]
        public void Validate_LessThanRequiredLength_ReturnsFalse(string password)
        {
            var validator = new DefaultPasswordValidator();

            Assert.IsFalse(validator.Validate(password));
        }

        [TestCase ("123456789;")]
        [TestCase ("aboo123><?")]
        [TestCase ("{ }suez")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string password)
        {
            var validator = new DefaultPasswordValidator();
            Assert.IsFalse(validator.Validate(password));
        }
    }
}
