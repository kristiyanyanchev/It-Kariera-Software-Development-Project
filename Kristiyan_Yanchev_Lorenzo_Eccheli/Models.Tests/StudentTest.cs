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
    public class StudentTest
    {
        [Test]
        public void Add_NormalConditions()
        {
            var repo = new StudentsTestRepository();
            var student = new Student("George", "Smith", DateTime.Today, true, "Johnson St.", "0001");
            var count = repo.List().Count();
            repo.Add(student);
            Assert.AreNotEqual(repo.List().Count(), count);
        }

        [Test]
        public void Add_NullLastName_ThrowsException()
        {
            var repo = new StudentsTestRepository();
            var student = new Student("George", null, DateTime.Today, true, "Johnson St.", "0001");
            Assert.Throws<DbEntityValidationException>(() => repo.Add(student));
        }

        [Test]
        public void Delete_DbDoesNotContainElement_ThrowsException()
        {
            var repo = new StudentsTestRepository();
            var student = new Student("George", "Smith", DateTime.Today, true, "Johnson St.", "0001");
            Assert.Throws<DbUpdateConcurrencyException>(() => repo.Delete(student));
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var repo = new StudentsTestRepository();
            var student = new Student("George", "Smith", DateTime.Today, true, "Johnson St.", "0001");
            repo.Add(student);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());
            Assert.AreNotEqual(count, repo.List().Count());
        }

        [Test]
        public void Edit_NormalConditions()
        {
            var repo = new StudentsTestRepository();
            var student = new Student("John", "Smith",DateTime.Today,true, "Johnson St.","0001");
            repo.Add(student);
            var editedStudent = repo.List().Last();
            editedStudent.FirstName = "George";
            repo.Edit(editedStudent);
            Assert.AreEqual(repo.List().Last().FirstName, "George");
        }

        [Test]
        public void GetById_NormalConditions()
        {
            var repo = new StudentsTestRepository();
            var student = new Student("John", "Smith", DateTime.Today, true, "Johnson St.", "0001");
            repo.Add(student);
            Assert.AreEqual(repo.GetById(repo.List().Last().Id).Id,repo.List().Last().Id);
        }

        [Test]
        public void GetById_IdLessThan0()
        {
            var repo = new StudentsTestRepository();
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }
    }
}
