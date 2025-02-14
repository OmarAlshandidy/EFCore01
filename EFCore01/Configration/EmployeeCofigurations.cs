using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore01.Configration
{
    internal class EmployeeCofigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
      
            
                E.HasKey(E => E.EmpId);
                E.Property(E => E.EmpId).UseIdentityColumn(1, increment: 1);
            

        }
    }
}
