using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test2_57122201043.Model;

namespace Test2_57122201043
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class StudentService : IStudentService
    {
        SchoolsContext db = new SchoolsContext();

        public bool AddStudent(Student std)
        {
            var student = db.Students.Find(std.ID);
            if(student == null)
            {
                db.Students.Add(std);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteStudent(Student std)
        {
            var student = db.Students.Find(std.ID);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Student GetStudent(int id)
        {
            Console.WriteLine("get student id : " + id);
            var std = db.Students.Find(id);

            if (std != null)
            {
                Console.WriteLine("get student : not null");
                return std;
            }
            Console.WriteLine("get student : null");
            return null;
        }

        public bool UpdateStudent(Student std)
        {
            var student = db.Students.Find(std.ID);
            if (student != null)
            {
                student.Name = std.Name;
                student.Gpa = std.Gpa;
                student.DateOfBirth = std.DateOfBirth;
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
