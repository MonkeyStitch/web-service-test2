using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Test2_ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2_57122201043.SchoolsContext schools = new Test2_57122201043.SchoolsContext();

            //Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
            //schools.Teachers.Find(1);
            //Console.WriteLine("Teachers find: 1");
            //schools.Departments.Find(1);
            //Console.WriteLine("Departments find: 1");

            using (ServiceHost host = new ServiceHost(typeof(Test2_57122201043.StudentService)))
            {
                host.Open();
                Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
