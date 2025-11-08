namespace BrushAndCanvas.Api.Data;
using Microsoft.EntityFrameworkCore;
using BrushAndCanvas.Api.Models;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Users> Users { get; set; } = default!;
    public DbSet<EmployeeProfiles> EmployeeProfiles { get; set; } = default!;
    public DbSet<CustomerProfiles> CustomerProfiles { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Employee Profiles Configuration
        modelBuilder.Entity<EmployeeProfiles>()
            .HasKey(ep => ep.UserId);

        modelBuilder.Entity<EmployeeProfiles>()
            .HasOne(ep => ep.User)
            .WithOne()
            .HasForeignKey<EmployeeProfiles>(ep => ep.UserId);

        // Customer Profiles Configuration
        modelBuilder.Entity<CustomerProfiles>()
            .HasKey(cp => cp.UserId);

        modelBuilder.Entity<CustomerProfiles>()
            .HasOne(cp => cp.User)
            .WithOne()
            .HasForeignKey<CustomerProfiles>(cp => cp.UserId);
    }
}
