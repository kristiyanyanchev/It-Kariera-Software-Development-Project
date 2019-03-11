using Controller.ValidationClasses.ValidationCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Tests.ValidationClasses.ValidationCode
{
    [TestFixture]
    public class DefaultValidationCodeValidatorTest
    {
        [TestCase("@1253")]
        [TestCase("!5362")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string code)
        {
            var validator = new DefaultValidationCodeValidator();
            Assert.False(validator.Validate(code));
        }
    }
}
