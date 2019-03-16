using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Controller.ValidationClasses.UCN;

namespace Controller.Tests.ValidationClasses.UCN
{
    [TestFixture]
    public class DefaultUcnValidatorTest
    {

        [TestCase("wqedaserdf")]
        [TestCase("aaas123456")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string ucn)
        {
            var validator = new DefaultUcnValidator();
            Assert.False(validator.Validate(ucn));
        }

        [TestCase("123")]
        [TestCase("12323213232132321312")]
        public void Validate_LengthLessThanRequired(string ucn)
        {
            var validator = new DefaultUcnValidator();
            Assert.False(validator.Validate(ucn));
        }

        [TestCase("sds1232")]
        [TestCase("1a123")]
        public void Validate_WrongFormat_ReturnsFalse(string ucn)
        {
            var validator = new DefaultUcnValidator();
            Assert.False(validator.Validate(ucn));
        }
    }
}
