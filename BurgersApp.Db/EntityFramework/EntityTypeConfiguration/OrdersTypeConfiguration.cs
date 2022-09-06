using BurgersApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgersApp.Db.EntityFramework.EntityTypeConfiguration
{
    public class OrdersTypeConfiguration
        : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.Address)
                   .HasMaxLength(512)
                   .IsRequired();

            builder.Property(p => p.BurgersInOrder)
                   .HasMaxLength(512)
                   .IsRequired();

            builder.Property(p => p.OrderDate)
                   .HasMaxLength(128)
                   .IsRequired();

            builder.Property(p => p.FirstName)
                   .HasMaxLength(64)
                   .IsRequired();

            builder.Property(p => p.LastName)
                   .HasMaxLength(64)
                   .IsRequired();

            builder.Property(p => p.TotalPrice)
                   .HasMaxLength(64)
                   .IsRequired();
        }
    }
}