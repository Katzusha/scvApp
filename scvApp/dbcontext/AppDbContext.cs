using Microsoft.EntityFrameworkCore;
using scvApp.Models;

namespace scvApp.dbcontext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=Database\database.db");

        public DbSet<Admin> Admins { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolSubmit> SchoolSubmits { get; set; }
        public DbSet<Submit> Submits { get; set; }
        public DbSet<SubmitTeacher> SubmitTeachers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Date> Dates { get; set; }
    }
}
