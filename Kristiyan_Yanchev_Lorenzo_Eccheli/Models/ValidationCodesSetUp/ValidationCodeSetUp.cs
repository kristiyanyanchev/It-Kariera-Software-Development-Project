using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ValidationCodesSetUp
{
    public class ValidationCodeSetUp
    {
       public static bool IsExecuted()
       {
            var repo = new ValidationCodeRepository();
            if (repo.List().Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
       }


        public void Execute()
        {
            if (IsExecuted() != true)
            {
                var repo = new ValidationCodeRepository();
                for (int i = 0; i < 1000; i++)
                {
                    repo.Add(new ValidationCode(i.ToString(), "Teacher"));

                }
                for (int i = 1000; i < 10000; i++)
                {
                    repo.Add(new ValidationCode(i.ToString(), "Student"));
                }
                for (int i = 10000; i < 20000; i++)
                {
                    repo.Add(new ValidationCode(i.ToString(), "Parent"));
                }
            }
           
        }


    }
}
