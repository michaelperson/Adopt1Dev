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
    public class SalaryUserConfig : IEntityTypeConfiguration<SalaryUser>
    {
        public void Configure(EntityTypeBuilder<SalaryUser> builder)
        {
            builder.ToTable(nameof(SalaryUser));
            builder.HasKey(s => new { s.SalaryId, s.UserId });

            builder.Property(s => s.Amount).IsRequired();

            builder.HasOne(s=>s.Salary)
                .WithMany(sa => sa.SalariesUser);

            builder.HasOne(s => s.User)
                .WithMany(u => u.SalariesUser);

            builder.HasCheckConstraint("CK_Amount", "Amount >0");
        }
    }
}
