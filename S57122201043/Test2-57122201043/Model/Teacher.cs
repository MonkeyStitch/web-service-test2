using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test2_57122201043.Model
{
    [DataContract]
    public partial class Teacher
    {
        [DataMember(Order = 1)]
        public int TeacherID { get; set; }

        [DataMember(Order = 2)]
        public string Name { get; set; }

        [DataMember(Order = 3), Required]
        public virtual Department Department { get; set; }
    }
}
