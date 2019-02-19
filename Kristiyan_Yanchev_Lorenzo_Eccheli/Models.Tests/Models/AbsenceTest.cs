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
    public class AbsenceTest
    {
        [Test]
        public void Constructor_NullStudent_ThrowsArgumentException()
        {
            var period = new Mock<IPeriod>().Object;
            Assert.Throws<ArgumentNullException>(() => { var absence = new Absence(true, null, period);  });
        }
        
        [Test]
        public void Constructor_NullPeriod_ThrowsArgumentException()
        {
            var student = new Mock<IStudent>().Object;
            Assert.Throws<ArgumentNullException>(() => { var absence = new Absence(true, student, null); });
        }

    }
}
