using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses.Username;

namespace Controller.Tests.ValidationClasses.Username
{
    [TestFixture]
    public class DefaultUsernameValidatorTest
    {
        [TestCase("aboo123")]
        [TestCase("12345")]
        [TestCase("@!#")]
        public void Validate_LessThanRequiredLength_ReturnsFalse(string password)
        {
            var validator = new DefaultUsernameValidator();

            Assert.IsFalse(validator.Validate(password));
        }

        [TestCase("123456789;")]
        [TestCase("aboo123><?")]
        [TestCase("{ }suez")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string password)
        {
            var validator = new DefaultUsernameValidator();
            Assert.IsFalse(validator.Validate(password));
        }
    }
    
}
