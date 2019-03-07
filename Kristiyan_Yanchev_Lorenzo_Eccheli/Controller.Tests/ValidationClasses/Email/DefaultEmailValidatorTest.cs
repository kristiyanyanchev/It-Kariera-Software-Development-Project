using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses.Email;

namespace Controller.Tests.ValidationClasses.Email
{
    [TestFixture]
    public class DefaultEmailValidatorTest
    {
        [TestCase("a")]
        [TestCase("12")]
        [TestCase("Suez")]
        public void Validate_LessThanRequiredLength_ReturnsFalse(string email)
        {
            var validator = new DefaultEmailValidator();
            Assert.False(validator.Validate(email));
        }

        [TestCase("georgi.com")]
        [TestCase("ivanMail.com")]
        [TestCase("SuezMail.com")]
        public void Validate_DoesNotContainsAtSign_ReturnsFalse(string email)
        {
            var validator = new DefaultEmailValidator();
            Assert.False(validator.Validate(email));
        }

        [TestCase("Suez@Canal")]
        [TestCase("toronto@c1ty")]
        [TestCase("pra_gue@c1ty")]
        public void Validate_DoesNotContainsDotSign_ReturnsFalse(string email)
        {
            var validator = new DefaultEmailValidator();
            Assert.False(validator.Validate(email));
        }

        [TestCase("SuezC@nal@canal.com")]
        [TestCase("*toronto@city.com")]
        [TestCase("Prague@city.cz.com")]
        public void Validate_ContainsForbiddenChars(string email)
        {
            var validator = new DefaultEmailValidator();
            Assert.False(validator.Validate(email));
        }

    }
}
