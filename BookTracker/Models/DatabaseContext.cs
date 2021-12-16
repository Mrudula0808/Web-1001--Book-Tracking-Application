using BookTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookTracker.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Book> Books { get; set; }       
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public string databasePath { get; private set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={$"{Environment.CurrentDirectory + "/Database"}{System.IO.Path.DirectorySeparatorChar}BookTracker.db"}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
        }
    }

}
