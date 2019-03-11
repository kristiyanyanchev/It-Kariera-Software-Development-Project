using Data.Models;
using Data.Test.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

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
            Assert.Throws<DbEntityValidationException>(() => { repo.Add(code);  });
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001", "Student");
            repo.Add(code);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());
            Assert.AreNotEqual(count, repo.List().Count());
        }

        [Test]
        public void Delete_DbDoesNotContainElelemnt_ThrowsException()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001", "Student");
            //Trows Exception if Delete() did not changed anything in Db.
            Assert.Throws<System.Data.Entity.Infrastructure.DbUpdateConcurrencyException>(() => { repo.Delete(code); });
        }

        [Test]
        public void Edit_NormalConditions()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001", "Student");
            repo.Add(code);
            code = repo.List().Last();
            code.Code = "0002";
            repo.Edit(code);
            Assert.AreEqual(repo.List().Last().Code, code.Code);
        }
        
        [Test]
        public void GetById_NormalConditions()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001", "Student");
            repo.Add(code);
            Assert.AreEqual(repo.GetById(1).Id, 1);
        }

        [Test]
        public void GetById_IdLessThan0_ThrowsException()
        {
            var repo = new ValidationCodeTestRepository();
            var code = new ValidationCode("0001", "Student");
            repo.Add(code);
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }
    }
}
