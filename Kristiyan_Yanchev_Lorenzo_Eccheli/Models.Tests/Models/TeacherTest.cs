using Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Models
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void Constructor_NullFirstName_ThrowArgumentNullException()
        {
           Assert.Throws<ArgumentNullException>(() =>{ var teacher = new Teacher(null, "lastName", 1, "position", "UCN"); });
        }

        [Test]
        public void Constructor_NullLastName_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var teacher = new Teacher("FirstName", null, 1, "position", "UCN"); });
        }

        [Test]
        public void Constructor_SalaryLessThanZero_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => { var teacher = new Teacher("firstName", "lastName", -1, "position", "UCN"); });
        }
        [Test]
        public void Constructor_NullPosition_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var teacher = new Teacher("firstName", "lastName", 1, null, "UCN"); });
        }
        [Test]
        public void Constructor_NullUCN_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var teacher = new Teacher("firstName", "lastName", 1, "position", null); });
        }

    }
}
