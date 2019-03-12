using Data.Models;
using Data.Repositories;
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

    }
}
