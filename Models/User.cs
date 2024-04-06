using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class User
{
    public int UserId { get; set; } // Changed from Id to UserId
    public string Username { get; set; }
  
    public User()
    {
        Username = "";
    }
}
