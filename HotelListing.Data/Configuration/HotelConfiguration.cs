using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Zvezda",
                    Address = "Minsk",
                    Rating = 3.4,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Pantheon Hotel",
                    Address = "Rome",
                    Rating = 4.8,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Moscow City Hotel",
                    Address = "Moscow",
                    Rating = 4.1,
                    CountryId = 3
                }
            );
        }
    }
}
