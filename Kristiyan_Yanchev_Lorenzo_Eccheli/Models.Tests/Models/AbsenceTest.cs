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
    public class AbsenceTest
    {
        [Test]
        public void Constructor_NullStudent_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => { var absence = new Absence(true,null,new Period("Math",DateTime.Today,DateTime.Now,new)); });
        }
    }
}
