using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class StudentsRepository : IRepository<Student>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Student entity)
        {
            context.Students.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Student entity)
        {
            context.Students.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Student entity)
        {
            var result = context.Students.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Student GetById(int id)
        {
            return context.Students.Single(x => x.Id == id);
        }

        public IEnumerable<Student> List()
        {
            return context.Students.ToList();
        }
    }
}
