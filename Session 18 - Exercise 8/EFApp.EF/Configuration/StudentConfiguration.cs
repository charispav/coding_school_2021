using EFApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EFApp.EF {
    public class StudentConfiguration : IEntityTypeConfiguration<Student> {
        

        public void Configure(EntityTypeBuilder<Student> builder) {
            builder.ToTable("Student", "Student");

            builder.Property(student => student.ID).ValueGeneratedOnAdd();
            builder.Property(student => student.Name).HasMaxLength(200).IsRequired(true);
            builder.Property(student => student.Surname).HasMaxLength(200).IsRequired(true);
            builder.Property(student => student.BirthDate).IsRequired(true);
            builder.Property(student => student.Address).IsRequired(true);
        }
    }
}
