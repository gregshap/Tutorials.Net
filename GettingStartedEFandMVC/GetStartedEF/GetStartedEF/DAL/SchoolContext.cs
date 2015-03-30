using GregshapUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GregshapUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext()
            : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //in VAN we actually like plural table names. 
            //Not sure what oberon does, or what we want for extracted apps?
            //Leaving the override here for now so its singular as in the tutorial
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}