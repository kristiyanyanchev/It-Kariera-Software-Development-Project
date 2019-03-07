using Controller.ValidationClasses.NameOfChild;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Tests.ValidationClasses.NameOfChild
{
    [TestFixture]
    public class DefaultNameOfChildValidatorTest
    {
        [TestCase("Ivan2")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string name)
        {
            var validator = new DefaultNameOfChildValidator();
            Assert.False(validator.Validate(name));
        }

        [TestCase("ivan ivanov")]
        [TestCase("IvAn Ivanov")]
        [TestCase("IvanIvanov")]
        [TestCase("Iv@n Ivanov")]
        public void Validate_WrongFormat_ReturnsFalse(string name)
        {
            var validator = new DefaultNameOfChildValidator();
            Assert.False(validator.Validate(name));
        }
        
        [TestCase("i i")]
        [TestCase("")]
        public void Validate_LengthLessThanRequired(string name)
        {
            var validator = new DefaultNameOfChildValidator();
            Assert.False(validator.Validate(name));
        }
    }
}
