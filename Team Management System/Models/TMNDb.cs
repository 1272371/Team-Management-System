using Team_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Team_Management_System.Data
{
    public class TMNDb : DbContext
    {
        public TMNDb(DbContextOptions<TMNDb> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Practice_Session> Practice_Sessions { get; set; }
        public DbSet<Match_Session> Match_Sessions { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Practice_Session>().ToTable("Practice_Session");
            modelBuilder.Entity<Match_Session>().ToTable("Match_Session");
            modelBuilder.Entity<Game>().ToTable("Game");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Player>().ToTable("Player");
        }
    }
}