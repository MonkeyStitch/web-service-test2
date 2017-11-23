using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test2_57122201043.Interface;
using Test2_57122201043.Model;

namespace Test2_57122201043
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class TeacherService : ITeacherService
    {
        SchoolsContext db = new SchoolsContext();

        public bool AddTeacher(Teacher teacher)
        {
            var tch = db.Teachers.Find(teacher.TeacherID);
            if (tch == null)
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public bool DeleteTeacher(Teacher teacher)
        {
            var tch = db.Teachers.Find(teacher.TeacherID);
            if (tch != null)
            {
                db.Teachers.Remove(tch);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public Teacher GetTeacher(int id)
        {
            var tch = db.Teachers.Find(id);

            if (tch != null)
            {
                return tch;
            }
            return null;
        }


        public bool UpdateTeacher(Teacher teacher)
        {
            var tch = db.Teachers.Find(teacher.TeacherID);
            if (tch != null)
            {
                tch.Name = teacher.Name;
                tch.Department.DepartName = teacher.Department.DepartName;
                db.Entry(tch).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
