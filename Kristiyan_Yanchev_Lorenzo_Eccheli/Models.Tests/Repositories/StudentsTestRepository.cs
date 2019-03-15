using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class StudentsTestRepository : StudentsRepository
    {
        public override void Add(Student entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Students.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Student entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Students.Attach(entity);
                context.Students.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Student entity)
        {
            using (var context = new TestClassbookContext())
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
                result.Schoolarship = entity.Schoolarship;
                result.Ucn = entity.Ucn;
                result.ValidationCode = entity.ValidationCode;
                context.SaveChanges();
            }
        }

        public override Student GetById(int id)
        {
            Student result;
            using (var context = new TestClassbookContext())
            {
                result = context.Students.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Student> List()
        {
            List<Student> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Students.ToList();
            }
            return result;
        }
    }
}
