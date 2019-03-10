using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;
namespace Data.Test.Repositories
{
    class ValidationCodeTestRepository : ValidationCodeRepository
    {
        public override void Add(ValidationCode entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.ValidationCodes.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(ValidationCode entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.ValidationCodes.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(ValidationCode entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.ValidationCodes.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override ValidationCode GetById(int id)
        {
            ValidationCode result;
            using (var context = new TestClassbookContext())
            {
                result = context.ValidationCodes.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<ValidationCode> List()
        {
            List<ValidationCode> result;
            using (var context = new TestClassbookContext())
            {
                result = context.ValidationCodes.ToList();
            }
            return result;
        }

        
    }
}
