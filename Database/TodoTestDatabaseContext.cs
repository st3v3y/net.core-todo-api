using System;
using aspnetTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aspnetTest.Database
{
    public partial class TodoTestDatabaseContext : DbContext
    {
        public DbSet<Todo> Todos {get; set;}

        public TodoTestDatabaseContext()
        {
        }

        public TodoTestDatabaseContext(DbContextOptions<TodoTestDatabaseContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
