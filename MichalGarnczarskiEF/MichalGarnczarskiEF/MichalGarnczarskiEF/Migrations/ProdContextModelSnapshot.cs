﻿// <auto-generated />
using MichalGarnczarskiEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MichalGarnczarskiEF.Migrations
{
    [DbContext(typeof(ProdContext))]
    partial class ProdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("MichalGarnczarskiEF.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
