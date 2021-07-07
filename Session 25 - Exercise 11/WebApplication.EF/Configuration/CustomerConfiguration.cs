using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApplication.Model;

namespace WebApplication.EF.Configuration {

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {

        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customer", "Customer");

            builder.Property(customer => customer.ID).ValueGeneratedOnAdd();
            builder.Property(customer => customer.Name).HasMaxLength(200).IsRequired(true);
            builder.Property(customer => customer.Surname).HasMaxLength(200).IsRequired(true);
            builder.Property(customer => customer.AFM).HasMaxLength(9).IsRequired(true);
            builder.Property(customer => customer.Active).IsRequired(true);
        }
    }
}
