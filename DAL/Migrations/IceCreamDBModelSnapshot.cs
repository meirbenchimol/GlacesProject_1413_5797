﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(IceCreamDB))]
    partial class IceCreamDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

          
            modelBuilder.Entity("BE.Shop", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaceBookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSiteLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });


            modelBuilder.Entity("BE.IceCream", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ShopId")
                    .HasColumnType("nvarchar(450)");

                b.Property<double?>("Calories")
                    .HasColumnType("float");

                b.Property<string>("Comments")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("Energy")
                    .HasColumnType("float");

                b.Property<string>("Image")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Images")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Marks")
                    .HasColumnType("nvarchar(max)");


             //   b.Property<string>("MedianGrade")
                   // .HasColumnType("nvarchar(max)");

                b.Property<double?>("Proteins")
                    .HasColumnType("float");

                b.Property<string>("Taste")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id", "ShopId");

                b.ToTable("IceCreams");
            });

#pragma warning restore 612, 618
        }
    }
}
