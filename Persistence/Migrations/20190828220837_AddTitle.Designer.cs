﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190828220837_AddTitle")]
    partial class AddTitle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tony Bradshaw"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Heather Bradshaw"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lorelei Bradshaw"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Layla Bradshaw"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
