using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test2_57122201043.Model;

namespace Test2_57122201043.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface ITeacherService
    {
        [OperationContract]
        Teacher GetTeacher(int id);

        [OperationContract]
        bool AddTeacher(Teacher teacher);

        [OperationContract]
        bool UpdateTeacher(Teacher teacher);

        [OperationContract]
        bool DeleteTeacher(Teacher teacher);
    }
}
