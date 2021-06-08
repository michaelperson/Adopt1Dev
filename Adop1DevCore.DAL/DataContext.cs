using Adopte1DevCore.DAL.Datas;
using Adopte1DevCore.DAL.Entities;
using Adopte1DevCore.DAL.EntityConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.DAL
{
    public class DataContext : DbContext
    {
        private readonly string _cnstr;

        public DataContext()
        {
            _cnstr= @"data source=(localdb)\MSSQLLocalDB;initial catalog=Adop1Dev;integrated security=true";
        }
        public DataContext(string ConnectionString)
        {
            _cnstr = ConnectionString;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<SalaryUser> SalariesUser { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillUser> SkillsUser { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_cnstr);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new SalaryConfig());
            builder.ApplyConfiguration(new SalaryUserConfig());
            builder.ApplyConfiguration(new SkillConfig());
            builder.ApplyConfiguration(new SkillUserConfig());
            builder.ApplyConfiguration(new UserConfig());
            InitDB.LoadData(builder);
        }


    }
}
