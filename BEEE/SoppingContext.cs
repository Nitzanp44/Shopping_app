using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BEEE
{
    public class SoppingContext : DbContext
    {
    
            public DbSet<Product> Products { get; set; }
            public DbSet<SoppingList> SoppingLists { get; set; }
            public DbSet<User> Users { get; set; }
        
    }
}
