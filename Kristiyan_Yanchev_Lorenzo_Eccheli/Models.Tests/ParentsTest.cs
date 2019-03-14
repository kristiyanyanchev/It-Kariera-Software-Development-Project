using Data.Models;
using Data.Test.Repositories;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test
{
    [TestFixture]
    public class ParentsTest
    {
        [Test]
        public void Add_NormalConditions()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", "Smith", "Johnson St.", "0004");
            var count = repo.List().Count();
            repo.Add(parent);
            Assert.AreNotEqual(count, repo.List().Count());
        }

        [Test]
        public void Add_NullLastName_ThrowsException()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", null, "Johnson St.", "0004");

            Assert.Throws<DbEntityValidationException>(() => repo.Add(parent));
        }

        [Test]
        public void Delete_DbDoesNotContainElement()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", "Smith", "Johnson St.", "0004");
            Assert.Throws<DbUpdateConcurrencyException>(() => repo.Delete(parent));
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", "Smith", "Johnson St.", "0004");
            repo.Add(parent);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());
            Assert.AreNotEqual(count, repo.List().Count());
        }

        [Test]
        public void Edit_NormalConditions()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", "Smith", "Johnson St.", "0004");
            repo.Add(parent);
            var editedParent = repo.List().Last();
            editedParent.FirstName = "George";
            repo.Edit(editedParent);
            Assert.AreEqual(repo.List().Last().FirstName, "George");
        }

        [Test]
        public void GetById_IdLessThan0()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", "Smith", "Johnson St.", "0004");
            repo.Add(parent);
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }
        
        [Test]
        public void GetById_NormalConditions()
        {
            var repo = new ParentsTestRepository();
            var parent = new Parent("John", "Smith", "Johnson St.", "0004");
            repo.Add(parent);
            Assert.AreEqual(repo.GetById(repo.List().Last().Id).Id,repo.List().Last().Id);
        }
    }
}
