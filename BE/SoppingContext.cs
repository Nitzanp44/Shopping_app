using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace BE
{
    public class SoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<SoppingList> SoppingLists { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
