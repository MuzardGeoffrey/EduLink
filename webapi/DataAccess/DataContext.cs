namespace webapi.DataAccess
{
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.EntityFrameworkCore;
    using webapi.DataAccess.Seed;
    using webapi.Object;

    public class DataContext : DbContext
    {
        private readonly IConfiguration Configuration;

        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            GenerateTable(modelBuilder);
            GenerateSeed(modelBuilder);
        }

        private static void GenerateTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>()
                .Property(s => s.EnumSubject)
                .HasConversion(
                v => v.ToString(),
                v => (EnumSubject)Enum.Parse(typeof(EnumSubject), v));

            modelBuilder.Entity<User>()
                .HasMany(u => u.Subjects)
                .WithMany(s => s.Users);
        }

        private static void GenerateSeed(ModelBuilder modelBuilder)
        {
            SubjectSeed.GenerateData(modelBuilder);
        }
    }
}