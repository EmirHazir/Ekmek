using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ekmek.UI.Entity
{
    public class MyDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MyDataContext():base("DataConnection"){
            Database.SetInitializer(new DataInitializer());
        }

    }
}