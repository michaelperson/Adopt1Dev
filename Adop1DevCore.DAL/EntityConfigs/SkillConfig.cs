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
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable(nameof(Skill));
            builder.HasKey(s => s.SkillId);

            builder.Property(s=>s.Label)
              .HasMaxLength(255)
              .IsRequired();

            builder.HasMany(s=> s.Categories)
                .WithMany(c => c.Skills);


            builder.HasIndex(s => s.Label).IsUnique(true);
        }
    }
}
