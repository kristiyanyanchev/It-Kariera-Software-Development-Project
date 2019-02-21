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
    public class PeriodTest
    {
        [Test]
        public void Constructor_NullSubject_ThowsArgumentNullException()
        {
            var teacher = new Mock<ITeacher>().Object;
            var @class = new Mock<IClass>().Object;

            Assert.Throws<ArgumentNullException>(() => { new Period(null, DateTime.Today, DateTime.Now, teacher, @class); });
        }

        [Test]
        public void Constructor_StartTimeBefore1900_ThowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            var @class = new Mock<IClass>().Object;

            Assert.Throws<ArgumentException>(() => { new Period("Math", new DateTime(1899,1,1), DateTime.Now, teacher, @class); });
        }

        [Test]
        public void Constructor_EndTimeBefore1900_ThowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            var @class = new Mock<IClass>().Object;

            Assert.Throws<ArgumentException>(() => { new Period("Math", new DateTime(1900, 1, 1), new DateTime(1900, 1, 1), teacher, @class); });
        }
        [Test]
        public void Constructor_StartTimeAfterEndTime_ThowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            var @class = new Mock<IClass>().Object;

            Assert.Throws<ArgumentException>(() => { new Period("Math", new DateTime(1900, 1, 2), new DateTime(1900, 1, 1), teacher, @class); });
        }

        [Test]
        public void Constructor_NullTeacher_ThowsArgumentNullException()
        {
            
            var @class = new Mock<IClass>().Object;

            Assert.Throws<ArgumentNullException>(() => { new Period("Math", DateTime.Today, DateTime.Now, null, @class); });
        }

        [Test]
        public void Constructor_NullClass_ThowsArgumentNullException()
        {
            var teacher = new Mock<ITeacher>().Object;

            Assert.Throws<ArgumentNullException>(() => { new Period("Math", DateTime.Today, DateTime.Now, teacher, null); });
        }

    }
}
