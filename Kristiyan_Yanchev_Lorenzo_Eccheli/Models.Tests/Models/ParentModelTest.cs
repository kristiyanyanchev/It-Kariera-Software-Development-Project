using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace Data.Test.Models
{
    [TestFixture]
    public class ParentModelTest
    {
        [TestCase(-1,"Ivan","Georgiev","Adress")]
        public void Constructor_NegativeId_ThrowArgumentException(int id,string firstName,string lastName,string address)
        {
             Assert.Throws<ArgumentException>(() => {
                 new Parent(id, firstName, lastName, address);
             });

        }
        
        [TestCase(1,"Ge0rgi","Ivanov","Address")]
        [TestCase(1, "Ge@rgi", "Ivanov", "Address")]
        [TestCase(1, "Georg1", "Ivanov", "Address")]
        [TestCase(1, "Ge_rgi", "Ivanov", "Address")]
        [TestCase(1, "GeArgi", "Ivanov", "Address")]
        [TestCase(1, "gergi", "Ivanov", "Address")]

        public void Constructor_FirstNameContainsNotOnlyLetters_ThrowArgumentException(int id, string firstName, string lastName, string address)
        {
            Assert.Throws<ArgumentException>(() => {
                new Parent(id, firstName, lastName, address);
            });
        }

        [TestCase(1, "Georgi", "Ivanov", "Address")]

        public void Constructor_FirstNameContainsOnlyLetters_ReturnsTrue(int id, string firstName, string lastName, string address)
        {
            var parent = new Parent(id, firstName, lastName, address);
            Assert.True(parent.FirstName == firstName);
        }

        [TestCase(1,"Georgi","Iv@nov","Address")]
        [TestCase(1, "Georgi", "ivanov", "Address")]
        [TestCase(1, "Georgi", "Iv_anov", "Address")]
        [TestCase(1, "Georgi", "Iva nov", "Address")]
        [TestCase(1, "Georgi", "IvanOv", "Address")]
        [TestCase(1, "Georgi", "Ivan0v", "Address")]

        public void Consturctor_LastNameContainsNotOnlyLetters_ThrowsArgumentException(int id,string firstName,string lastName,string address)
        {
            Assert.Throws<ArgumentException>(() => {
                new Parent(id, firstName, lastName, address);
            });
        }

        [TestCase(1, "Georgi", "Ivanov", "Address")]

        public void Constructor_LastNameContainsOnlyLetters_ReturnsTrue(int id, string firstName, string lastName, string address)
        {
            var parent = new Parent(id, firstName, lastName, address);
            Assert.True(parent.LastName == lastName);
        }

        [TestCase(1,"Georgi","Ivanov","")]
        [TestCase(1, "Georgi", "Ivanov", "ul#Ivan Asen 41")]
        [TestCase(1, "Georgi", "Ivanov", "ul$Ivan Asen 41")]
        [TestCase(1, "Georgi", "Ivanov", "ul_Ivan Asen 41")]

        public void Constructor_AddressContainsForbiddenCharacters_ThrowsArgumentException(int id, string firstName, string lastName, string address)
        {
            Assert.Throws<ArgumentException>(() => {
                new Parent(id, firstName, lastName, address);
            });
        }

        [TestCase(1, "Georgi", "Ivanov", "ul.Ivan Asen 41")]
        [TestCase(1, "Georgi", "Ivanov", "ul-Ivan Asen 41")]

        public void Constructor_AddressDontContainsForbiddenCharacters_ReturnsTrue(int id, string firstName, string lastName, string address)
        {
            var parent = new Parent(id, firstName, lastName, address);
            Assert.True(parent.Address == address);
        }
    }
}
