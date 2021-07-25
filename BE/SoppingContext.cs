using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace BE
{
    class SoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<SoppingList> SoppingLists { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
