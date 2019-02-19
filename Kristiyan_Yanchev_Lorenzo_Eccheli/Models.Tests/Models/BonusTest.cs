using Data.ModelInterfaces;
using Data.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Models
{
    [TestFixture]
    public class BonusTest
    {
        [Test]
        public void Constructor_AmountLessThanZero_ThrowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            Assert.Throws<ArgumentException>(() => { var bonus = new Bonus(-1, "SS", teacher); });
        }

        [Test]
        public void Constructor_NullDescription_ThrowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            Assert.Throws<ArgumentException>(() => { var bonus = new Bonus(1, null, teacher);  });
        }

        [Test]
        public void Constructor_NullTeacher_ThrowArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => { var bonus = new Bonus(1, "a", null); });
        }
    }
}
