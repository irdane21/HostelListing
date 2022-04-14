using HostelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
                });
        }
    }
}
