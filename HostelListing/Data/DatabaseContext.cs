using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FR"
                },
                new Country
                {
                    Id = 3,
                    Name = "United Kingdom",
                    ShortName = "UK"
                },
                new Country
                {
                    Id = 4,
                    Name = "United States of America",
                    ShortName = "USA"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals resort spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Westminster",
                    Address = "london",
                    CountryId = 3,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "George V",
                    Address = "Paris",
                    CountryId = 2,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Ceasar Palace",
                    Address = "Las Vegas",
                    CountryId = 2,
                    Rating = 1
                }
            );
        }
    }
}
