using Microsoft.EntityFrameworkCore;
using ZooBase.Models.Animals.Entities;

namespace ZooBase.Data; 
public class ApplicationDbContext : DbContext {
    public DbSet<Mammal> Mammals { get; set; }
    public DbSet<Bird> Birds { get; set; }
    public DbSet<Amphibian> Amphibians { get; set; }
    public DbSet<UnknownAnimal> UnknownAnimals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("server=localhost;database=animalsBase;user id=sa;password=sa;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Mammal>(a =>
        {
            a.Property<int>("Id");
            a.HasKey("Id");
        });
        modelBuilder.Entity<Amphibian>(a => {
            a.Property<int>("Id");
            a.HasKey("Id");
        });
        modelBuilder.Entity<Bird>(a => {
            a.Property<int>("Id");
            a.HasKey("Id");
        });
        modelBuilder.Entity<UnknownAnimal>(a => {
            a.Property<int>("Id");
            a.HasKey("Id");
        });
    }
}
