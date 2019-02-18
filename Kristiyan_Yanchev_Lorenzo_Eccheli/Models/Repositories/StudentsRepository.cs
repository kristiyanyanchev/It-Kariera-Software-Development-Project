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
            using (var context = new ClassBookContext())
            {
                return context.Students.Single(x => x.Id == id);
            }
           
        }

        public IEnumerable<Student> List()
        {
            using (var context = new ClassBookContext())
            {
                return context.Students.ToList();
            }
            
        }
    }
}
