using Data.ModelInterfaces;
using Data.Models;
using Data.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    [TestFixture]
    public class AbsencesRepositoryTest
    {
        [Test]
        public void Add_NormalConditions_AddtoDb()
        {
            var repository = new AbsencesRepository();
            var student = new Student("Ivan", "Dragan", DateTime.Today, true, "0000000001");
            new StudentsRepository().Add(student);
            var period = new Mock<IPeriod>().Object;
            var absence = new Absence(true, student, period);

            repository.Add(absence);

            Assert.AreEqual(repository.List().Last().IsLate, true);
        }
    }
}
