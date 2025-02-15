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
    internal class Course_Inst_Config : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> Ins_Cr)
        {
           Ins_Cr.HasKey(ci => new { ci.Ins_ID, ci.Course_ID });
        }
    }
}
