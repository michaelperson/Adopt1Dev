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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));
            builder.HasKey(s => s.CategoryId);

            builder.Property(s => s.Label)
              .HasMaxLength(255)
              .IsRequired();

            builder.HasMany(c => c.Skills)
                .WithMany(s => s.Categories);

            builder.HasIndex(s => s.Label).IsUnique(true);
        }
    }
}
