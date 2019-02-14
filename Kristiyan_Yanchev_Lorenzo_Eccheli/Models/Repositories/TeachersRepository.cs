using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class TeachersRepository : IRepository<Teacher>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Teacher entity)
        {
            context.Teachers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Teacher entity)
        {
            context.Teachers.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Teacher entity)
        {
            var result = context.Teachers.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Teacher GetById(int id)
        {
            return context.Teachers.Single(x => x.Id == id);
        }

        public IEnumerable<Teacher> List()
        {
            return context.Teachers.ToList();
        }
    }
}
