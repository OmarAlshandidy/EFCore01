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
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D=>D.ID);

            D.Property(D => D.Name)
                           .IsRequired()
                           .HasMaxLength(100)
                           .HasColumnType("varchar")
                           .HasColumnName("DepartmentName");

            D.Property(D => D.HiringDate)
            .IsRequired()
            .HasColumnType("date");
        }
    }
}
