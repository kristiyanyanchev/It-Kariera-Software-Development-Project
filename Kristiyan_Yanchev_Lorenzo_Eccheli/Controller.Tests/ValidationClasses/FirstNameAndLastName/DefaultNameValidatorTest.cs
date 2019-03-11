using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses.FirstNameAndLastName;

namespace Controller.Tests.ValidationClasses.FirstNameAndLastName
{
    [TestFixture]
    public class DefaultNameValidatorTest
    {
        [TestCase ("A")]
        [TestCase ("X")]
        public void Validate_LessThanRequiredLength_ReturnsFalse(string name)
        {
            var validator = new DefaultNameValidator();
            Assert.False(validator.Validate(name));
        }

        [TestCase ("georgi")]
        [TestCase( "GeorGi")]
        [TestCase ("Georg1")]
        [TestCase ("#georgi")]
        public void Validate_ContainsForbiddenChars_ReturnFalse(string name)
        {
            var validator = new DefaultNameValidator();
            Assert.False(validator.Validate(name));
        }
    }
}
