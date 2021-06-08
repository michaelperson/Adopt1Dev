using Adopte1DevCore.ASP.Helpers.Sessions;
using Adope1DevCore.ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Adopte1DevCore.ASP.Models;
using Adopte1DevCore.Models.Interfaces;
using Adopte1DevCore.Models;
using Adopte1DevCore.DAL.Entities;

namespace Adopte1DevCore.ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<CategoryModel, Category> _catService;
        private readonly IService<SkillModel, Skill> _skillService;
        public HomeController(ILogger<HomeController> logger, IService<CategoryModel, Category> catService, IService<SkillModel, Skill> skillService)
        {
            _logger = logger;
            _catService = catService;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            HomeViewModel Hm = new HomeViewModel(_catService, _skillService);


            return View(Hm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
