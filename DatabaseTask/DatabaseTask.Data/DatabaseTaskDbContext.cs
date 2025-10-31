using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Subjekt> Subjekts { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
