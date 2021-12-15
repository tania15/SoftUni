﻿namespace Theatre.Data
{
    using Microsoft.EntityFrameworkCore;
    using Theatre.Data.Models;

    public class TheatreContext : DbContext
    {
        public DbSet<Play> Plays { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public TheatreContext() { }

        public TheatreContext(DbContextOptions options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }
    }
}
