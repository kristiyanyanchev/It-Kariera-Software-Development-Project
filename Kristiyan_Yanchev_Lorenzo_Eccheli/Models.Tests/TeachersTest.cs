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
    public class TeachersTest
    {
        [Test]
        public void Add_NormalConditions()
        {
            var repo = new TeachersTestRepository();
            var teacher = new Teacher("John", "Smtih", "Math", "Junior", "0002");
            var count = repo.List().Count();
            repo.Add(teacher);
            Assert.AreNotEqual(repo.List().Count(), count);
        }

        [Test]
        public void Add_NullLastName_ThrowsException()
        {
            var repo = new TeachersTestRepository();
            var teacher = new Teacher("John", null, "Math", "Junior", "0002");
            Assert.Throws<DbEntityValidationException>(() => repo.Add(teacher));
        }

        [Test]
        public void Delete_DbDoesNotContainElement_ThrowsException()
        {
            var repo = new TeachersTestRepository();
            var teacher = new Teacher("John", "Smtih", "Math", "Junior", "0002");
            Assert.Throws<DbUpdateConcurrencyException>(() => repo.Delete(teacher));
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var repo = new TeachersTestRepository();
            var teacher = new Teacher("John", "Smtih", "Math", "Junior", "0002");
            repo.Add(teacher);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());
            Assert.AreNotEqual(count, repo.List().Count());
        }

        [Test]
        public void Edit_NormalConditions()
        {
            var repo = new TeachersTestRepository();
            var teacher = new Teacher("John", "Smtih", "Math", "Junior", "0002");
            repo.Add(teacher);
            var editedTeacher = repo.List().Last();
            editedTeacher.FirstName = "George";
            repo.Edit(editedTeacher);
            Assert.AreEqual(repo.List().Last().FirstName, "George");
        }

        [Test]
        public void GetById_NormalConditions()
        {
            var repo = new TeachersTestRepository();
            var teacher = new Teacher("John", "Smtih", "Math", "Junior", "0002");
            repo.Add(teacher);
            Assert.AreEqual(repo.List().Last().Id, repo.GetById(repo.List().Last().Id).Id);
        }

        [Test]
        public void GetById_IdLessThan0()
        {

            var repo = new TeachersTestRepository();
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }

    }
}
