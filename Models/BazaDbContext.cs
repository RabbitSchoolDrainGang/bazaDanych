using Microsoft.EntityFrameworkCore;

namespace bazaDanych.Models
{
    public class BazaDbContext : DbContext
    {
        public BazaDbContext(DbContextOptions<BazaDbContext> options) : base(options){}

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game() { Id = 1, Title = "Wiedźmin 3: Dziki Gon", Genre = {"Action", "Fabular"}, Platform = { "Steam", "GOG" }, ReleaseDate = "19.05.2015" },
                new Game() { Id = 2, Title = "Wielcy Złodzieje Aut: Święty Andrzej", Genre = { "Action", "Fabular" }, Platform = { "Steam", "Rockstar Games Luncher" }, ReleaseDate = "26.10.2004" }
            );
        }
    }
}
