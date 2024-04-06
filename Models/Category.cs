using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Category
{
    public int CategoryId { get; set; } // Changed from Id to CategoryId
    public string Name { get; set; }
    
    public Category()
    {
        Name = "";
    }
}