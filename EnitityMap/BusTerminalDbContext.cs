﻿using BusTerminal.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusTerminal.EnitityMap
{
    public class BusTerminalDbContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusSeat> BusSeats { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Trip> Trips { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-J9VL7Q5\\SQLEXPRESS;Initial Catalog=TaavBusTerminal;" +
                "Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BusTerminalDbContext).Assembly);
        }
    }
}
