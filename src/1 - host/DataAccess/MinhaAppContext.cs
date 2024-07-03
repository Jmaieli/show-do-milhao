using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Domain;

namespace MinhaPrimeiraAPI.DataAccess
{
    public class MinhaAppContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<PlayerAnswer> PlayerAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }

        public MinhaAppContext(DbContextOptions<MinhaAppContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            MapPlayer(modelBuilder);
        }

        void MapPlayer(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Player>()
            //    .ToTable("player")
            //     .HasKey(p => p.PlayerId).HasName("id");

            //modelBuilder.Entity<Player>()
            //    .Property(p => p.Name)
            //    .HasColumnName("player_name");
        }

    }

}
