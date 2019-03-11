using Data.Models;
using Data.Test.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test
{
    [TestFixture]
    public class ValidationCodeTest
    {
        [Test]
        public void Add_NormalConditions()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001","Student");
            repo.Add(code);

            Assert.AreEqual(repo.List().Last().Id, code.Id);
        }
        [Test]
        public void Add_NullRole_ThrowsException()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001", null);


            Assert.Throws<Exception>(() => { repo.Add(code); });
        }
    }
}
