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
    public class GradeRecordTest
    {
        [Test]
        public void Add_NormalCondtions()
        {
            var repo = new GradesTestRepository();
            var student = new Student("John","Smith",DateTime.Today,true,"Johnson St.","0003");
            var grade = new GradeRecord(6.00, DateTime.Today, "Math", student);
            var count = repo.List().Count();
            repo.Add(grade);
            Assert.AreNotEqual(repo.List().Count(), count);
        }

        [Test]
        public void Add_NullStudent_ThrowsException()
        {
            var repo = new GradesTestRepository();
            var grade = new GradeRecord(6.00, DateTime.Today, "Math", null);
            Assert.Throws<DbEntityValidationException>(() => repo.Add(grade));
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var repo = new GradesTestRepository();
            var student = new Student("John", "Smith", DateTime.Today, true, "Johnson St.", "0003");
            var grade = new GradeRecord(6.00, DateTime.Today, "Math", student);
            repo.Add(grade);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());

            Assert.AreNotEqual(repo.List().Count(), count);
        }
        
        [Test]
        public void Delete_DbDoesNotContainElement()
        {
            var repo = new GradesTestRepository();
            var student = new Student("John", "Smith", DateTime.Today, true, "Johnson St.", "0003");
            var grade = new GradeRecord(6.00, DateTime.Today, "Math", student);
            Assert.Throws<DbUpdateConcurrencyException>(() => repo.Delete(grade));
        }

        [Test]
        public void Edit_NormalConditions()
        {
            var repo = new GradesTestRepository();
            var student = new Student("John", "Smith", DateTime.Today, true, "Johnson St.", "0003");
            var grade = new GradeRecord(6.00, DateTime.Today, "Math", student);
            repo.Add(grade);
            grade.Grade = 5.00;
            repo.Edit(grade);
            Assert.AreNotEqual(repo.List().Last().Grade, grade.Grade);
        }

        [Test]
        public void GetById_NormalConditions()
        {
            var repo = new GradesTestRepository();
            var student = new Student("John", "Smith", DateTime.Today, true, "Johnson St.", "0003");
            var grade = new GradeRecord(6.00, DateTime.Today, "Math", student);
            repo.Add(grade);
            Assert.AreEqual(repo.GetById(repo.List().Last().Id).Id, grade.Id);
        }

        [Test]
        public void GetById_IdLessThan0()
        {
            var repo = new GradesTestRepository();
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }
    }
}
