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
        IService<UserModel, User> _userService;
        public HomeViewModel(IService<CategoryModel, Category> catService, IService<SkillModel, Skill> skillService, IService<UserModel, User> userService)
        {
            _catService = catService;
            _skillService = skillService;
            _userService = userService;
        }

        public List<CategoryModel> Categories
        {
            get { return _catService.GetAll().ToList(); }
        }

        public List<SkillModel> Skills
        {
            get { return _skillService.GetAll().ToList(); }
        }
       
    public List<UserModel> Les6DerniersUsers
        {
            get { return _userService.GetAll().OrderByDescending(s=>s.UserId).Take(10).ToList(); }
        }
   

}
}
