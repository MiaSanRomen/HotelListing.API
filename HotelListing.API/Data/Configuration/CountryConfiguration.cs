using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Belarus",
                    ShortName = "BY"
                },
                new Country
                {
                    Id = 2,
                    Name = "Italy",
                    ShortName = "IT"
                },
                new Country
                {
                    Id = 3,
                    Name = "Russia",
                    ShortName = "RU"
                }
            );
        }
    }
}
