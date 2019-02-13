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
        
       
    }
}
