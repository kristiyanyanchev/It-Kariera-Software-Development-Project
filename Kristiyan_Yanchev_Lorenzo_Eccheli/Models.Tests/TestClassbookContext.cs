using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test
{
    class TestClassbookContext : ClassBookContext
    {
        private static string connectionString = "Server=.;Database=TestClassBookDb;Trusted_Connection=True;";
        public TestClassbookContext() : base(connectionString)
        {

        }
    }
}
