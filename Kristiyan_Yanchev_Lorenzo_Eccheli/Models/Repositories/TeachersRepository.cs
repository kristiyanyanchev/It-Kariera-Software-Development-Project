using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class TeachersRepository : IRepository<Teacher>
    {
        
        public virtual void Add(Teacher entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Teachers.Add(entity);
                context.SaveChanges();
            }
           
        }

        public virtual void Delete(Teacher entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Teachers.Attach(entity);
                context.Teachers.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Teacher entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Teachers.Single(x => x.Id == entity.Id);
                //result.Class = entity.Class;
                result.Email = entity.Email;
                result.FirstName = entity.FirstName;
                result.LastName = entity.LastName;
                result.PhoneNumber = entity.PhoneNumber;
                result.Position = entity.Position;
                result.Subject = entity.Subject;
                result.ValidationCode = entity.ValidationCode;
                context.SaveChanges();
            }
            
        }

        public virtual Teacher GetById(int id)
        {
            Teacher result;
            using (var context = new ClassBookContext())
            {
                result = context.Teachers.Single(x => x.Id == id);
            }
            
            return result;
        }

        public virtual IEnumerable<Teacher> List()
        {
            List<Teacher> result;
            using (var context = new ClassBookContext())
            {
                result = context.Teachers.ToList();
            }
            return result;
        }
    }
}
