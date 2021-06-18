using Adopte1DevCore.ASP.Models;
using Adopte1DevCore.DAL.Entities;
using Adopte1DevCore.Models;
using Adopte1DevCore.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1DevCore.ASP.Components
{
    [ViewComponent(Name = "TabControl")]
    public class TabControlViewComponent : ViewComponent
    {
        private readonly IService<CategoryModel, Category> _catService;
        private readonly IService<SkillModel, Skill> _skillService;
        private readonly IService<UserModel, User> _userService;
        public TabControlViewComponent(IService<CategoryModel, Category> catService, IService<SkillModel, Skill> skillService, IService<UserModel, User> userService)
        {
            _catService = catService;
            _skillService = skillService;
            _userService = userService;
        }

        public IViewComponentResult Invoke(string IdCategorie)
        {
            TabControlComponentViewModel TabHm = new TabControlComponentViewModel(_catService, _skillService, _userService);
            return View("TabControlComponent", TabHm);
        }
    }
}
