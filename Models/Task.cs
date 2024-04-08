using System;
using System.ComponentModel.DataAnnotations;

public class Task
{
    [Key]
    public int TaskId { get; set; }

    public int UserId { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; } // Optional if you allow tasks without descriptions

    public bool IsComplete { get; set; } // Indicates whether the task is completed

    public int CategoryId { get; set; }

}