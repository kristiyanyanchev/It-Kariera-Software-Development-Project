using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses.Address;

namespace Controller.Tests.ValidationClasses.Address
{
    [TestFixture]
    public class DefaultAddressValidatorTest
    {
        [TestCase("ul.Suez 25@")]
        [TestCase("ul.Ses@me 32")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string address)
        {
            var validator = new DefaultAddressValidator();
            Assert.False(validator.Validate(address));
        }

        [TestCase("ul Suez 25")]
        [TestCase ("ul.Sesame one")]
        [TestCase("ul.Sesameone")]
        [TestCase("ul Suez  25")]
        public void Validate_WrongFormat_ReturnsFalse(string address)
        {
            var validator = new DefaultAddressValidator();
            Assert.False(validator.Validate(address));
        }

        [TestCase("u.s 2")]
        public void Validate_LengthLessThanRequired(string address)
        {
            var validator = new DefaultAddressValidator();
            Assert.False(validator.Validate(address));
        }
    }
}
