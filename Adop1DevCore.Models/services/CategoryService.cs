using Adopte1DevCore.DAL;
using Adopte1DevCore.DAL.Entities;
using Adopte1DevCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.Models.services
{
    public class CategoryService : BaseService, IService<CategoryModel, Category>
    {
        

        public CategoryService(DataContext dc): base(dc)
        {
             
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            return _dc.Categories.Include("Skills").Select(c => new CategoryModel() 
            { 
                 CategoryId = c.CategoryId,
                 Label = c.Label,
                 Skills = c.Skills.Select(s=>new SkillModel() 
                                                {
                                                       SkillId = s.SkillId,
                                                        Label =s.Label
                                                 })
            });
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category form)
        {
            throw new NotImplementedException();
        }

        public void Update(Category form)
        {
            throw new NotImplementedException();
        }
    }
}
