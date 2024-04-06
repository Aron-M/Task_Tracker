using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
  
    public User()
    {
        Username = ""; // Initialize to empty string or another default value
    }
}
