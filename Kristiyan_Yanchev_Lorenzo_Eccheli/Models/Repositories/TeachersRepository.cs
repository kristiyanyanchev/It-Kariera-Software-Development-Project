using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class TeachersRepository : IRepository<Teacher>
    {
        
        public void Add(Teacher entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Teachers.Add(entity);
                context.SaveChanges();
            }
           
        }

        public void Delete(Teacher entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Teachers.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public void Edit(Teacher entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Teachers.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public Teacher GetById(int id)
        {
            Teacher result;
            using (var context = new ClassBookContext())
            {
                result = context.Teachers.Single(x => x.Id == id);
            }
            
            return result;
        }

        public IEnumerable<Teacher> List()
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
