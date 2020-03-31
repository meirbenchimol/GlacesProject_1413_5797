using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;
using BE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL
{
    class IceCreamDB : DbContext
    {

       /* public IceCreamDB(DbContextOptions<IceCreamDB> options) : base(options)
        {
        }*/

        public DbSet<Shop> Shops { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=IceCreamDB;Trusted_Connection=True;");

        }


       
       protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IceCream>()
           .Property(e => e.Comments)
           .HasConversion(v => string.Join(";", v), v => v.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));

            builder.Entity<IceCream>().HasKey(s => new { s.Id, s.ShopId });



            builder.Entity<IceCream>()
          .Property(e => e.Taste)
          .HasConversion(v => string.Join(";", v), v => v.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));


           builder.Entity<IceCream>()
          .Property(e => e.Images)
          .HasConversion(v => string.Join(";", v), v => v.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));

            var converter = new ValueConverter<int[], String>(
                v => String.Join(";", v),
                v => v.Split(';').Select(val => int.Parse(val)).ToArray());

            builder.Entity<IceCream>()
            .Property(e => e.marks)
            .HasConversion(converter);


            builder.Entity<Shop>()
           .Property(e => e.Images)
           .HasConversion(v => string.Join(";", v), v => v.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
        }

    }
}
