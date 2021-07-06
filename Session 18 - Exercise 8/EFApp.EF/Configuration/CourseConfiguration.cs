using EFApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp.EF.Configuration {
    public class CourseConfiguration : IEntityTypeConfiguration<Course> {
        public void Configure(EntityTypeBuilder<Course> builder) {
            builder.ToTable("Course", "Course");

            builder.HasKey(course => course.ID);

            builder.Property(course => course.ID).ValueGeneratedOnAdd();
            builder.Property(course => course.Title).HasMaxLength(200).IsRequired(true);
            builder.Property(course => course.Category).HasMaxLength(200).IsRequired(true);
            builder.Property(course => course.Date).IsRequired(true);
            builder.Property(course => course.Duration).IsRequired(true);

        }
    }
}
