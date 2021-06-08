using Adopte1DevCore.DAL.Entities;
using Adopte1DevCore.Models;
using Adopte1DevCore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1DevCore.ASP.Models
{
    public class HomeViewModel
    {
        IService<CategoryModel, Category> _catService;
        IService<SkillModel, Skill> _skillService;
        public HomeViewModel(IService<CategoryModel, Category> catService, IService<SkillModel, Skill> skillService)
        {
            _catService = catService;
            _skillService = skillService;
        }

        public List<CategoryModel> Categories
        {
            get { return _catService.GetAll().ToList(); }
        }

        public List<SkillModel> Skills
        {
            get { return _skillService.GetAll().ToList(); }
        }
    }
}
