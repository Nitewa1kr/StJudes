using StJudesStudentInfo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StJudesStudentInfo.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext") { }

        public DbSet<Students> Students { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}