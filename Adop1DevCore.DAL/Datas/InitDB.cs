using Adopte1DevCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.DAL.Datas
{
    public static class InitDB
    {
        public static void LoadData(ModelBuilder builder)
        {
            /*Ajout des catégories*/
            Category BackEnd = new Category() { CategoryId = 1, Label = "Développement Back-End" };
            builder.Entity<Category>().HasData(BackEnd);

            Category FrontEnd = new Category() { CategoryId = 2, Label = "Développement Front-End" };
            builder.Entity<Category>().HasData(FrontEnd);

            builder.Entity<Category>().HasData(new Category
            { CategoryId = 3, Label = "IOT" });

            Category BI = new Category
            { CategoryId = 4, Label = "Business Intelligence" };
            builder.Entity<Category>().HasData(BI);

            builder.Entity<Category>().HasData(new Category
            { CategoryId = 5, Label = "Big Data" });

            builder.Entity<Category>().HasData(new Category
            { CategoryId = 6, Label = "IA" });


            Category Bureautique = new Category
            { CategoryId = 7, Label = "Bureautique" };
            builder.Entity<Category>().HasData(Bureautique);

            builder.Entity<Category>().HasData(new Category
            { CategoryId = 8, Label = "Analyse" });

            /*Ajout des Skils*/
            builder.Entity<Skill>().HasData(new Skill { SkillId = 9, Label = "Angular" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 1, Label = "ASP.NET Core" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 5, Label = "C#" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 3, Label = "ColdFusion" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 13, Label = "Excel" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 6, Label = "Java" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 7, Label = "Javascript"  });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 4, Label = "Node"  });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 2, Label = "PHP"  });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 10, Label = "PowerBI"  });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 11, Label = "Qlick" });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 8, Label = "React"  });
            builder.Entity<Skill>().HasData(new Skill { SkillId = 12, Label = "Word" });

             
            
        }

        
    }
}
