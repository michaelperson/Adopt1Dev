using Adopte1DevCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.DAL.EntityConfigs
{
    public class SkillUserConfig : IEntityTypeConfiguration<SkillUser>
    {
        public void Configure(EntityTypeBuilder<SkillUser> builder)
        {
            builder.ToTable(nameof(SkillUser));
            builder.HasKey(s => new { s.SkillId, s.UserId });
            
            builder.Property(s => s.Level).IsRequired();

            builder.HasOne(s => s.User)
                .WithMany(u => u.SKillsUser);

            builder.HasOne(s => s.Skill)
                .WithMany(ss => ss.SkillsUser);

            builder.HasCheckConstraint("CK_Level", "Level >0");
        }
    }
}
