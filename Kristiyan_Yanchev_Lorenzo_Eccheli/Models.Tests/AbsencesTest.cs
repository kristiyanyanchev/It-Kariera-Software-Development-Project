using Data.Models;
using Data.Repositories;
using Data.Test.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test
{
    [TestFixture]
    public class AbsencesTest
    {
        [Test]
        public void Add_NormalConditions()
        {
            var absence = new Absence()
            {
                IsLate = true,
                Period = DateTime.Today,
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = new DateTime(2010,10,1),
                    InAbsentia = true,
                    Address = "se",
                    ValidationCode = "0001"
                }
            };
            var repo = new AbsenceTestRepository();
            repo.Add(absence);
       
            Assert.AreEqual(repo.List().Last().Id, absence.Id);
        }

        [Test]
        public void Delete_NormalConditions()
        {
            var absence = new Absence()
            {
                IsLate = true,
                Period = DateTime.Today,
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = new DateTime(2010, 10, 1),
                    InAbsentia = true,
                    Address = "se",
                    ValidationCode = "0001"
                }
            };
            var repo = new AbsenceTestRepository();
            repo.Add(absence);
            var count = repo.List().Count();
            repo.Delete(repo.List().Last());
            Assert.AreNotEqual(repo.List().Count(), count);
        }

        [Test]
        public void Delete_DbDoesNotContainElement_ThrowsException()
        {
            var absence = new Absence()
            {
                IsLate = true,
                Period = DateTime.Today,
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = new DateTime(2010, 10, 1),
                    InAbsentia = true,
                    Address = "se",
                    ValidationCode = "0001"
                }
            };
            var repo = new AbsenceTestRepository();
            Assert.Throws<System.Data.Entity.Infrastructure.DbUpdateConcurrencyException>(() => { repo.Delete(absence); });
        }

        [Test] 
        public void Edit_NormalConditions()
        {
            var absence = new Absence()
            {
                IsLate = true,
                Period = DateTime.Today,
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = new DateTime(2010, 10, 1),
                    InAbsentia = true,
                    Address = "se",
                    ValidationCode = "0001"
                }
            };
            var repo = new AbsenceTestRepository();
            repo.Add(absence);

            var editedAbsence = repo.List().Last();
            editedAbsence.IsLate = false;
            repo.Edit(editedAbsence);

        }

        [Test]
        public void GetById_NormalConditions()
        {
            var absence = new Absence()
            {
                IsLate = true,
                Period = DateTime.Today,
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = new DateTime(2010, 10, 1),
                    InAbsentia = true,
                    Address = "se",
                    ValidationCode = "0001"
                }
            };
            var repo = new AbsenceTestRepository();
            repo.Add(absence);
            Assert.AreEqual(repo.GetById(repo.List().Max(x => x.Id)).Id, repo.List().Max(x => x.Id));
        }

        [Test]
        public void GetById_IdLessThan0_ThrowsException()
        {
            var absence = new Absence()
            {
                IsLate = true,
                Period = DateTime.Today,
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = new DateTime(2010, 10, 1),
                    InAbsentia = true,
                    Address = "se",
                    ValidationCode = "0001"
                }
            };
            var repo = new AbsenceTestRepository();
            repo.Add(absence);
            Assert.Throws<InvalidOperationException>(() => repo.GetById(-1));
        }
    }

    
}
