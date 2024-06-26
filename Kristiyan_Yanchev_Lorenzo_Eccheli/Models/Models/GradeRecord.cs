﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class GradeRecord
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Grade { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public GradeRecord(double grade, DateTime date, string subject, int studentId)
        {
            Grade = grade;
            Date = date;
            Subject = subject;
            StudentId = studentId;
        }
        public GradeRecord(double grade, DateTime date, string subject, Student student)
        {
            Grade = grade;
            Date = date;
            Subject = subject;
            Student = student;

        }
        public GradeRecord()
        {

        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", StudentId, Subject, Grade, Date,Id);
        }
    }
}
