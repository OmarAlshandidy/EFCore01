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
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I=>I.Ins_Id);

            I.Property(i => i.Name)
                       .IsRequired()
                       .HasMaxLength(50)
                       .HasColumnType("varchar")
                       .HasColumnName("InstructorName");

            I.Property(i => i.Salary)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            I.Property(i => i.Bouns)
                  .HasColumnType("decimal(18,2)");

            I.Property(i => i.HourRate)
                       .HasColumnType("decimal(18,2)");

            I.Property(i => i.Address)
                       .HasMaxLength(300)
                       .HasColumnType("nvarchar");

            I.Property(i => i.Dept_ID)
          .HasColumnName("DepartmentId")
          .IsRequired();




        }
    }
}
