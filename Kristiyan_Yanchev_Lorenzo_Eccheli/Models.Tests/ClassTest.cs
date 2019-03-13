﻿using Data.Models;
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
    public class ClassTest
    {
        [Test]
        public void Add_NormalConditions()
        {
            var repo = new ClassesTestRepository();
            var teacher = new Teacher("John", "Smith", "Math", "Junior Teacher", "1234567890", "0001");
            var @class = new Class("Math", teacher);
            repo.Add(@class);
            Assert.AreEqual(@class.Id, repo.List().Last().Id);
        }

        [Test]
        public void Add_NullTeacher_ThrowsException()
        {
            var repo = new ClassesTestRepository();
            Teacher teacher = null;
            var @class = new Class("Math", teacher);
            Assert.Throws<DbEntityValidationException>(() => repo.Add(@class));
            
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var repo = new ClassesTestRepository();
            var teacher = new Teacher("John", "Smith", "Math", "Junior Teacher", "1234567890", "0001");
            var @class = new Class("Math", teacher);
            repo.Add(@class);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());
            Assert.AreNotEqual(count, repo.List().Count());
            
        }

        [Test]
        public void Delete_DbDoesNotContainElement()
        {
            var repo = new ClassesTestRepository();
            var teacher = new Teacher("John", "Smith", "Math", "Junior Teacher", "1234567890", "0001");
            var @class = new Class("Math", teacher);
            Assert.Throws<DbUpdateConcurrencyException>(() => repo.Delete(@class));
        }

        [Test]
        public void Edit_NormalCondtions()
        {
            var repo = new ClassesTestRepository();
            var teacher = new Teacher("John", "Smith", "Math", "Junior Teacher", "1234567890", "0001");
            var @class = new Class("Math", teacher);
            repo.Add(@class);
            var editedEntity = repo.List().Last();
            editedEntity.Name = "George";
            Assert.AreNotEqual(repo.List().Last().Name, "John");
        }

        [Test]
        public void GetById_NormalConditions()
        {
            var repo = new ClassesTestRepository();
            var teacher = new Teacher("John", "Smith", "Math", "Junior Teacher", "1234567890", "0001");
            var @class = new Class("Math", teacher);
            repo.Add(@class);
            Assert.AreEqual(repo.GetById(repo.List().Last().Id).Id, repo.List().Last().Id);
        }
        [Test]
        public void GetById_IdLessThan0()
        {
            var repo = new ClassesTestRepository();
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }
    }
}
