using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class StudentsRepository : IRepository<Student>
    {
         

        public void Add(Student entity)
        {
            using (var context = new ClassBookContext())
            {
               

                context.Students.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Students.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public void Edit(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Students.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public Student GetById(int id)
        {
            Student result;
            using (var context = new ClassBookContext())
            {
                result = context.Students.Single(x => x.Id == id);
            }
            return result;

        }

        public IEnumerable<Student> List()
        {
            List<Student> result;
            using (var context = new ClassBookContext())
            {
                result = context.Students.ToList();
            }
            return result;
        }
    }
}
