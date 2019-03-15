using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Controller.ValidationClasses.Money;

namespace Controller.Tests.ValidationClasses.Money
{
    [TestFixture]
    public class DefaultMoneyValidatorTest
    {
        [TestCase("asdq2313")]
        [TestCase("231asdd")]
        public void Validate_ContainsForbiddenChars_ReturnsFalse(string money)
        {
            var validator = new DefaultMoneyValidator();
            Assert.False(validator.Validate(money));
        }

        [TestCase("0123232")]
        [TestCase("0232321")]
        public void Validate_WrongFormat_ReturnsFalse(string money)
        {
            var validator = new DefaultMoneyValidator();
            Assert.False(validator.Validate(money));
        }


    }
}
