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
    public class GradeRecordTest
    {
        [Test]
        public void Constructor_GradeLessThan0_ThrowsArgumentException()
        {
            var student = new Mock<IStudent>().Object;
            Assert.Throws<ArgumentException>(() => { var gradeRecord = new GradeRecord(-1, DateTime.Now, student); });
        }

        [Test]
        public void Constructor_DateTimeBefore1900_ThrowsArgumentException()
        {
            var student = new Mock<IStudent>().Object;
            Assert.Throws<ArgumentException>(() => { var gradeRecord = new GradeRecord(1,new DateTime(1899,1,1) , student); });
        }

        [Test]
        public void Constructor_NullStudent_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var gradeRecord = new GradeRecord(1, DateTime.Now, null); });
        }
    }
}
