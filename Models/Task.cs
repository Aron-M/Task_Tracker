using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

public class Task
{
    public int UserId { get; set; }
    public string Title { get; set; }
    [Key]
    public int TaskId { get; set; }
    
    public Task()
    {
        Title = ""; 
    }
}