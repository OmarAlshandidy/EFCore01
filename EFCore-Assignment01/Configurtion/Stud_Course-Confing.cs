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
    internal class Stud_Course_Confing : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> CS)
        {
            CS.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
        }
    }
}
