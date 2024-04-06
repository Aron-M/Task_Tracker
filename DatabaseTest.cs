using System;
using System.Linq;
using TaskTrackerDbContext.Data; // Replace with your DbContext namespace
using Task_tracker_API.Models; // Replace with your models namespace

public class DatabaseTest
{
    public static void Main(string[] args)
    {
        using (var context = new TaskTrackerDbContext()) // Replace with your actual DbContext
        {
            var categories = context.Categories.ToList();
            var users = context.Users.ToList();

            Console.WriteLine($"Number of categories: {categories.Count}");
            Console.WriteLine($"Number of users: {users.Count}");
        }
    }
}