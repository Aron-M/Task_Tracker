using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Task_tracker_API.Data
{
    public class TaskTrackerDbContext : IdentityDbContext<IdentityUser>
    {
        public TaskTrackerDbContext(DbContextOptions<TaskTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            base.OnModelCreating(modelBuilder);

            // Seed data for Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "Alice", Email = "Alice@example.com", Password = "password" },
                new User { UserId = 2, Username = "Bob", Email = "Bob@example.com", Password = "password"}
                // Add more users as needed
            );

            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Work" },
                new Category { CategoryId = 2, Name = "Personal" }
                // Add more categories as needed
            );

            // Seed data for Tasks
            modelBuilder.Entity<Task>().HasData(
                new Task { TaskId = 1, Title = "Sample Task", Description = "This is a sample task description.", CategoryId = 1, UserId = 1, IsComplete = false },
                new Task { TaskId = 2, Title = "Another Task", Description = "This is another task description.", CategoryId = 2, UserId = 2, IsComplete = false }
                // Add more tasks as needed
            );
        }
    }
}