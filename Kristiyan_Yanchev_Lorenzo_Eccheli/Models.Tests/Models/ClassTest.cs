using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Moq;
using Data.ModelInterfaces;

namespace Data.Test.Models
{
    [TestFixture]
    public class ClassTest
    {
        [Test]
        public void Constructor_NullClassName_ThrowsArgumentNullException()
        {
            var teacher = new Mock<ITeacher>().Object;
            Assert.Throws<ArgumentNullException>(() => { var @class = new Class(null, teacher); });
        }

        [Test]
        public void Constructor_NullTeacher_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var @class = new Class("11g", null); });
        }
        



    }
}
