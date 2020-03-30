using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
//using Microsoft.EntityFrameworkCore;

namespace DAL
{
    class IceCreamDB : DbContext
    {

       /* public IceCreamDB(DbContextOptions<IceCreamDB> options) : base(options)
        {
        }*/

        public DbSet<Shop> Shops { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }*/
    }
}
