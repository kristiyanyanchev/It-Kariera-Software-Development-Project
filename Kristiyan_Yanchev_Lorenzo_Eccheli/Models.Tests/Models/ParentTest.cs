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
    public class ParentTest
    {
        [Test]
        public void Constructor_NullFirstName_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Parent(null, "lastName", "address"); });
        }

        [Test]
        public void Constructor_NullLastName_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Parent("firstName", null, "address"); });
        }

        [Test]
        public void Constructor_NullAddress_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Parent("firstName", "lastName", null); });
        }

        [Test]
        public void Constructor_NullEmail_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Parent("firstName", "lastName", "address",null,"phonenumber"); });
        }

        [Test]
        public void Constructor_NullPhoneNumber_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var parent = new Parent("firstName", "lastName", "address", "email", null); });
        }


    }
}
