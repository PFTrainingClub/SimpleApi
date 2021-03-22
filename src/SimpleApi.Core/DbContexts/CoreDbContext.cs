using Microsoft.EntityFrameworkCore;
using SimpbeApi.Core.Entities;

namespace SimpbeApi.Core.DbContexts
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Grade>()
                .HasKey(e => new { e.StudentId, e.SubjectId });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
