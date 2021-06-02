using Adop1DevCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adop1DevCore.DAL.EntityConfigs
{
    public class SalaryConfig : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.ToTable(nameof(Salary));
            builder.HasKey(s => s.SalaryId);

            builder.Property(s => s.Label)
               .HasMaxLength(255)
               .IsRequired();

            builder.HasIndex(s => s.Label).IsUnique(true);
        }
    }
}
