using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CatalogConstructor.Models;

namespace CatalogConstructor.Repository
{
    public class ParfumeContext : DbContext
    {
        public ParfumeContext(): base("ParfumeDB")
        { }

        public DbSet<Brand>  Brands{ get; set; }
    }
}