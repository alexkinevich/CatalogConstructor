using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogConstructor.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
    }
}