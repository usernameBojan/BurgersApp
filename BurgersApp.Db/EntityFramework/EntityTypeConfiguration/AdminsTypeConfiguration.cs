using BurgersApp.Domain.Models;
using Isopoh.Cryptography.Argon2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgersApp.Db.EntityFramework.EntityTypeConfiguration
{
    public class AdminsTypeConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(p => p.FirstName)
            .HasMaxLength(64)
            .IsRequired();

            builder.Property(p => p.LastName)
            .HasMaxLength(64)
            .IsRequired();

            builder.Property(p => p.Password)
            .HasMaxLength(20)
            .IsRequired();

            builder.HasData(new Admin(1, "John", "Smith", "Johnsy11990055", "desetbukvi", "123456789101112")); // FOR TESTING ONLY, NO WAY TO SEED LIKE THIS IN RL !!
        }
    }
}