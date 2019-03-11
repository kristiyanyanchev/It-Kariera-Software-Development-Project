using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class ValidationCodeRepository : IRepository<ValidationCode>
    {
        public virtual void Add(ValidationCode entity)
        {
            using (var context = new ClassBookContext())
            {
                context.ValidationCodes.Add(entity);
                context.SaveChanges();
            }
        }

        public virtual void Delete(ValidationCode entity)
        {
            using (var context = new ClassBookContext())
            {
                context.ValidationCodes.Attach(entity);
                context.ValidationCodes.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(ValidationCode entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.ValidationCodes.Single(x => x.Id == entity.Id);
                result.Role = entity.Role;
                result.Used = entity.Used;
                result.Code = entity.Code;
                context.SaveChanges();
            }
            
        }

        public virtual ValidationCode GetById(int id)
        {
            ValidationCode result;
            using (var context = new ClassBookContext())
            {
                result = context.ValidationCodes.Single(x => x.Id == id);
            }
            return result;
            
        }

        public virtual IEnumerable<ValidationCode> List()
        {
            List<ValidationCode> result;
            using (var context = new ClassBookContext())
            {
                result = context.ValidationCodes.ToList();
            }
            return result;
            
        }
    }
}
