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
    public class ResponsibilityTest
    {
        [Test]
        public void Constructor_NullName_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var responsibility = new Responsibility(null, "description"); });
        }

        [Test]
        public void Constructor_NullDescription_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { var responsibility = new Responsibility("name",null); });
        }
    }
}
