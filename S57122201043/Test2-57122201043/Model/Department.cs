using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test2_57122201043.Model
{
    [DataContract]
    public partial class Department
    {
        [DataMember(Order = 1)]
        public int DepartmentID { get; set; }

        [DataMember(Order = 2)]
        public string DepartName { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
