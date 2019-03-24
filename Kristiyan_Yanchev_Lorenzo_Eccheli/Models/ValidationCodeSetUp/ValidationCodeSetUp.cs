using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ValidationCodeSetUp
{
    public class ValidationCodeSetUp
    {
        public static void CopyCodesFromTextFileToDB()
        {
            var validationCodesRepo = new ValidationCodeRepository();
            var validationCodesStr = File.ReadAllLines("ValidationCodes.txt").ToList();
            var codesObj = new List<object>();

            if (validationCodesRepo.List().Count() ==0)
            {
                validationCodesStr.ForEach(x => {
                    var code = x.Split(new string[] { " => " }, StringSplitOptions.None)[0];
                    var role = x.Split(new string[] { " => " }, StringSplitOptions.None)[1];
                    validationCodesRepo.Add(new ValidationCode(code, role));

                });
            }
           

        }
    }
}
