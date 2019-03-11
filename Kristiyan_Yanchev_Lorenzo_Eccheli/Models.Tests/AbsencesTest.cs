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
        public void AddTest()
        {
            var absence = new Absence()
            {
                IsLate = true,
                //Period = new Period()
                //{
                //    StartTime = DateTime.MinValue,
                //    EndTime = DateTime.MaxValue,
                //},
                Student = new Student()
                {
                    FirstName = "a",
                    LastName = "b",
                    BirthDate = DateTime.MinValue,
                    InAbsentia = true,
                    Address = "se"
                }
            };
            var repo = new AbsenceTestRepository();
            repo.Add(absence);

            Assert.AreSame(repo.List().Last(), absence);
        }
    }
}
