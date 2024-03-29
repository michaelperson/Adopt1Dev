﻿using Adopte1DevCore.DAL.Entities;
using Adopte1DevCore.Models;
using Adopte1DevCore.Models.Interfaces;
using Adopte1DevCore.Models.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1DevCore.ASP.Models
{
    public class TabControlComponentViewModel
    {
        readonly IService<CategoryModel, Category> _catService; 
        readonly IService<UserModel, User> _userService;
        public TabControlComponentViewModel(IService<CategoryModel, Category> catService,   IService<UserModel, User> userService)
        {
            _catService = catService; 
            _userService = userService;
        }

        public List<CategoryModel> Categories
        {
            get {
                IEnumerable<CategoryModel> cat = _catService.GetAll().ToList();
                foreach (CategoryModel item in cat)
                {
                    item.Users = (_userService as UserService).GetAllByCategory(item.CategoryId);
                }
                return cat.ToList(); }
        }

        

    }
}
