using Microsoft.EntityFrameworkCore;
using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.Data
{
    public class NebulaDbContext : DbContext
    {
        public NebulaDbContext(DbContextOptions<NebulaDbContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<UserFlight> UserFlights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>()
                .HasMany(d => d.Flights)
                .WithOne(f => f.Destination);

            modelBuilder.Entity<Spaceship>()
                .HasMany(s => s.Flights)
                .WithOne(f => f.Spaceship);

            modelBuilder.Entity<UserFlight>()
                .HasKey(uf => new { uf.UserId, uf.FlightId});

            modelBuilder.Entity<UserFlight>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserFlights)
                .HasForeignKey(uf => uf.UserId);

            modelBuilder.Entity<UserFlight>()
                .HasOne(uf => uf.Flight)
                .WithMany(f => f.UserFlights)
                .HasForeignKey(uf => uf.FlightId);
        }
    }
}
