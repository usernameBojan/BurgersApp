using BurgersApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgersApp.Db.EntityFramework.EntityTypeConfiguration
{
    public class LocationsTypeConfiguration
        : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(p => p.Name)
            .HasMaxLength(512)
            .IsRequired();

            builder.Property(p => p.Address)
            .HasMaxLength(512)
            .IsRequired();

            builder.Property(p => p.OpensAt)
            .HasMaxLength(64)
            .IsRequired();

            builder.Property(p => p.ClosesAt)
            .HasMaxLength(64)
            .IsRequired();

            builder.Property(p => p.Id)
            .IsRequired();

            builder.HasData(
                new Location(1, "PseudoBurgers Tetovo", "Boulevard Ilirija 9999, Tetovo", "09:00", "23:00"),
                new Location(2, "PseudoBurgers Gjorche Petrov", "Gjorche Petrov 9999, Gjorche Petrov, Skopje", "10:00", "22:00"),
                new Location(3, "PseudoBurgers Center", "Boulevard Partizanski Odredi 9999, Center, Skopje", "08:00", "00:00"),
                new Location(4, "PseudoBurgers Aerodrom", "Boulevard Jane Sandanski 9999, Aerodrom, Skopje", "09:00", "00:00"),
                new Location(5, "PseudoBurgers Ohrid", "Boulevard Turistichka 9999, Ohrid", "08:00", "00:00"),
                new Location(6, "ForCRUDTesting", "ForCRUDTesting", "test", "test")
                );
        }
    }
}