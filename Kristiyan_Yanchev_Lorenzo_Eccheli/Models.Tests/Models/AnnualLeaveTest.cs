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
    public class AnnualLeaveTest
    {
        [Test]
        public void Constructor_StartDateBefore1900_ThrowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            Assert.Throws<ArgumentException>(() => { var leave = new AnnualLeave(new DateTime(1899,1,1), DateTime.Now, teacher); });
        }

        [Test]
        public void Constructor_EndDateBefore1900_ThrowsArgumentException()
        {
            var teacher = new Mock<ITeacher>().Object;
            
            Assert.Throws<ArgumentException>(() => { var leave = new AnnualLeave(new DateTime(1900, 1, 1),new DateTime(1900,1,1), teacher); });
        }

        [TestCase("01/21/2012", "01/20/2012")]
        public void Constructor_EndDateBeforeStartDate_ThrowsArgumentException(DateTime startDate ,DateTime endDate)
        {
            var teacher = new Mock<ITeacher>().Object;

            Assert.Throws<ArgumentException>(() => { var leave = new AnnualLeave(startDate,endDate,teacher); });
        }
    }
}
