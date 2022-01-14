using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFLibCore
{
    public partial class StudentContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> options) :base(options) { }

        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = LAPTOP-0B202ONM; Database = StudentDB; integrated security = True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity => entity.ToTable("Student"));
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}