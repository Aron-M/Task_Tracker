using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Category()
    {
        Name = ""; // Initialize to empty string or another default value
    }
}