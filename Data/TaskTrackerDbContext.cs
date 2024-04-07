using Microsoft.EntityFrameworkCore;


namespace Task_tracker_API.Data
{
    public class TaskTrackerDbContext : DbContext
{
    public TaskTrackerDbContext(DbContextOptions<TaskTrackerDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { UserId = 1, Username = "Alice", Email = "Alice@example.com", Password = "password" },
            new User { UserId = 2, Username = "Bob", Email = "Bob@example.com", Password = "password"}
            // Add more users as needed
        );

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Work", /* other properties */ },
            new Category { CategoryId = 2, Name = "Personal", /* other properties */ }
            // Add more categories as needed
        );

        modelBuilder.Entity<Task>().HasData(
            new Task { TaskId = 1, Title = "Task 1", CategoryId = 1, UserId = 1, /* other properties */ },
            new Task { TaskId = 2, Title = "Task 2", CategoryId = 2, UserId = 2, /* other properties */ }
            // Add more tasks as needed
        );
    }
}
}
