using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test2_57122201043.Model;

namespace Test2_57122201043
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        bool AddStudent(Student std);

        [OperationContract]
        bool UpdateStudent(Student std);

        [OperationContract]
        bool DeleteStudent(Student std);
    }
}
