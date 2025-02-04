﻿using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {  
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Value>()
                .HasData(
                    new Value { Id = 1, Name = "Tony Bradshaw", Title="Father" },
                    new Value { Id = 2, Name = "Heather Bradshaw", Title="Mother" },
                    new Value { Id = 3, Name = "Lorelei Bradshaw", Title="Daughter" },
                    new Value { Id = 4, Name = "Layla Bradshaw", Title="Daughter" }
                );

        }
    }
}
