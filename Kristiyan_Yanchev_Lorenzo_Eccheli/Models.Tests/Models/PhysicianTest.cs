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
    public class PhysicianTest
    {
        [Test]
        public void Constructor_NullFirstName_ThrowArgumentNullExcepiton()
        {
            Assert.Throws<ArgumentNullException>(() => { var physician = new Physician(null, "lastName", "address"); });
        }

        [Test]
        public void Constructor_NullLastName_ThrowArgumentNullExcepiton()
        {
            Assert.Throws<ArgumentNullException>(() => { var physician = new Physician("firstName",null, "address"); });
        }

        [Test]
        public void Constructor_NullAddress_ThrowArgumentNullExcepiton()
        {
            Assert.Throws<ArgumentNullException>(() => { var physician = new Physician("firstName", "lastName", null); });
        }

        [Test]
        public void Constructor_NullEmail_ThrowArgumentNullExcepiton()
        {
            Assert.Throws<ArgumentNullException>(() => { var physician = new Physician("firstName", "lastName",null, "phoneNumber", "address"); });
        }
        [Test]
        public void Constructor_NullPhoneNumber_ThrowArgumentNullExcepiton()
        {
            Assert.Throws<ArgumentNullException>(() => { var physician = new Physician("firstName", "lastName", "email", null, "address"); });
        }
    }
}
