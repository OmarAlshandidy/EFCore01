using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_Assignment01.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Assignment01.Configurtion
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(C=>C.Id);  
            C.Property(C=>C.Name)
                        .IsRequired()
                            .HasColumnType("varchar")
                            .HasColumnName("CourseName");
            
            C.Property(c => c.Description)
                           .HasMaxLength(300)
                           .HasColumnType("nvarchar")
                           .HasColumnName("CourseDescription");

            C.Property(c => c.Duration)
                    .IsRequired()
                    .HasColumnType("int");

            C.Property(c => c.Top_ID)
                          .HasColumnName("TopicId")
                          .IsRequired();


        }
    }
}
