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
    public class DepartmentService : IDepartmentService
    {
        SchoolsContext db = new SchoolsContext();

        public bool AddDepartment(Department dep)
        {
            var depm = db.Departments.Find(dep.DepartmentID);
            if (depm == null)
            {
                db.Departments.Add(dep);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteDepartment(Department dep)
        {
            var depm = db.Teachers.Find(dep.DepartmentID);
            if (depm != null)
            {
                db.Teachers.Remove(depm);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public Department GetDepartment(int id)
        {
            var depm = db.Departments.Find(id);

            if (depm != null)
            {
                return depm;
            }
            return null;
        }


        public bool UpdateDepartment(Department dep)
        {
            var depm = db.Departments.Find(dep.DepartmentID);
            if (depm != null)
            {
                depm.DepartName = dep.DepartName;
                depm.Teacher.Name = dep.Teacher.Name;
                db.Entry(depm).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
