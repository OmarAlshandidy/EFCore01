using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFCore_Assignment01.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Assignment01.Configurtion
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
           S.HasKey(S => S.Id);

                S.Property(S => S.FName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasColumnName("StudentName");

            S.Property(s => s.LName)
           .IsRequired(false)
           .HasMaxLength(50)
           .HasColumnType("varchar");

            S.Property(s => s.Age)
           .HasColumnType("int")
           .HasColumnName("StudentAge");


            S.Property(s => s.Address)
           .HasMaxLength(100)
           .HasColumnType("nvarchar")
           .HasColumnName("StudentAddress");

            S.Property(s => s.Dep_Id)
            .HasColumnName("DepartmentId")
            .IsRequired();





        }
    }
}
