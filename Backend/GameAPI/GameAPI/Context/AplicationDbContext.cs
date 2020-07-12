using GameAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Context
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlatformGame>().HasKey(x => new { x.GameId, x.PlatformId });
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlatformGame> PlatformGames { get; set; }

    }
}
