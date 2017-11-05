using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test2_57122201043.Model
{
    [DataContract]
    public class Student
    {
        //private int _id;
        //private string _name;
        //private DateTime _dateOfBirth;
        //private double _gpa;

        //[DataMember(Order = 1)]
        //public int ID {
        //    get { return _id; }
        //    set { _id = value; }
        //}

        //[DataMember(Order = 2)]
        //public string Name {
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //[DataMember(Order = 3)]
        //public DateTime DateOfBirth {
        //    get { return _dateOfBirth; }
        //    set { _dateOfBirth = value; }
        //}

        //[DataMember(Order = 4)]
        //public double Gpa {
        //    get { return _gpa; }
        //    set { _gpa = value; }
        //}

        [DataMember(Order = 1)]
        public int ID { get; set; }

        [DataMember(Order = 2)]
        public string Name { get; set; }

        [DataMember(Order = 3)]
        public DateTime DateOfBirth { get; set; }

        [DataMember(Order = 4)]
        public double Gpa { get; set; }
    }
}
