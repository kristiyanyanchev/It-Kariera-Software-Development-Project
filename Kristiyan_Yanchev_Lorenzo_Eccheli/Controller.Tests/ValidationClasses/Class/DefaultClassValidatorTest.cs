using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ValidationClasses.Class;

namespace Controller.Tests.ValidationClasses.Class
{
    [TestFixture]
    public class DefaultClassValidatorTest
    {
        [TestCase("11 A")]
        [TestCase("A11")]
        public void Validate_WrongFormat_ReturnsFalse(string @class)
        {
            var validator = new DefaultClassValidator();
            Assert.False(validator.Validate(@class));
        }

    }
}
