namespace Test2_57122201043
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Model;

    public class SchoolsContext : DbContext
    {
        // Your context has been configured to use a 'SchoolsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Test2_57122201043.SchoolsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SchoolsContext' 
        // connection string in the application configuration file.
        public SchoolsContext()
            : base("name=SchoolsContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}