using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;

namespace DAL
{
    class IceCreamDB : DbContext
    {

        public DbSet<Shop> Shops { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }
    }
}
