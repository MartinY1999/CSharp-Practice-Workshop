namespace SULS.Data
{
    using Microsoft.EntityFrameworkCore;
    using SULS.Models;

    public class SULSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<UserProblem> UserProblems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString: DatabaseSettings.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Problem>().HasKey(p => p.Id);
            modelBuilder.Entity<Submission>().HasKey(s => s.Id);
            modelBuilder.Entity<UserProblem>().HasKey(up => new { up.UserId, up.ProblemId });

            modelBuilder.Entity<Submission>().HasOne(s => s.User);
            modelBuilder.Entity<Submission>().HasOne(s => s.Problem);
            modelBuilder.Entity<User>().HasMany(u => u.Problems)
                .WithOne(up => up.User)
                .HasForeignKey(up => up.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}