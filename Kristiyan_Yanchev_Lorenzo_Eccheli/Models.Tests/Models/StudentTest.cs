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
    public class StudentTest
    {
        [Test]
        public void Constructor_NullFirstName_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Student(null, "lastName",DateTime.Now ,true,"Ucn"); });
        }

        [Test]
        public void Constructor_NullLastName_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Student("firstName", null, DateTime.Now, true, "Ucn"); });
        }

        [Test]
        public void Constructor_NullUCN_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Student("firstName", "lastName", DateTime.Now, true, null); });
        }

        [Test]
        public void Constructor_BirthDateBefore1900_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => { var parent = new Student("firstName", "lastName", new DateTime(1899,1,1), true, "ucn"); });
        }
    }
}
