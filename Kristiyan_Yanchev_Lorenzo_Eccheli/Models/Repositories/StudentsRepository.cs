using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Data.Repositories
{
    public class StudentsRepository : IRepository<Student>
    {
         

        public virtual void Add(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Students.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Students.Attach(entity);
                context.Students.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Students.Single(x => x.Id == entity.Id);
                result.Absences = entity.Absences;
                result.Address = entity.Address;
                result.BirthDate = entity.BirthDate;
                result.Class = entity.Class;
                result.Email = entity.Email;
                result.FirstName = entity.FirstName;
                result.GradeRecords = entity.GradeRecords;
                result.InAbsentia = entity.InAbsentia;
                result.LastName = entity.LastName;
                result.Parents = entity.Parents;
                result.PhoneNumber = entity.PhoneNumber;
                result.Ucn = entity.Ucn;
                result.ValidationCode = entity.ValidationCode;
                context.SaveChanges();
            }
            
        }

        public virtual Student GetById(int id)
        {
            Student result;
            using (var context = new ClassBookContext())
            {
                result = context.Students.Single(x => x.Id == id);
            }
            return result;

        }

        public virtual IEnumerable<Student> List()
        {
            List<Student> result;
            using (var context = new ClassBookContext())
            {
                result = context.Students.Include(x => x.Class).ToList();
            }
            return result;
        }
    }
}
