using Adopte1DevCore.ASP.Controllers;
using Adopte1DevCore.ASP.Models;
using Adopte1DevCore.DAL.Entities;
using Adopte1DevCore.Models;
using Adopte1DevCore.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Adopte1DevCore.ASP.Test
{
    public class Tests
    {

        //Create Mocking Services
        Mock<IService<CategoryModel, Category>> _catService = new Mock<IService<CategoryModel, Category>>();
        Mock<IService<SkillModel, Skill>> _skillService = new Mock<IService<SkillModel, Skill>>();
        Mock<IService<UserModel, User>> _userService = new Mock<IService<UserModel, User>>();





        [SetUp]
        public void Setup()
        {
            /*Mes listes*/
            List<SkillModel> AllSkills = new List<SkillModel>()
                               {
                                    new SkillModel()
                                    {
                                         SkillId = 1,
                                         Label ="ASP.NET Core"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 2,
                                         Label ="PHP"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 3,
                                         Label ="ColdFusion"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 4,
                                         Label ="Node"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 4,
                                         Label ="C#"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 6,
                                         Label ="Java"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 7,
                                         Label ="JavaScript"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 8,
                                         Label ="React"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 9,
                                         Label ="Angular"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 10,
                                         Label ="PowerBI"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 11,
                                         Label ="Qlick"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 12,
                                         Label ="Word"
                                    },
                                    new SkillModel()
                                    {
                                         SkillId = 13,
                                         Label ="Excel"
                                    }
                               };
            List<UserModel> AllUsers = new List<UserModel>()
            {
                new UserModel(){
       UserId=1,
       Email="blarver0@icio.us",
       FirstName="Burnard",
       LastName="Larver",Photo="" },
                new UserModel(){
                       UserId=2,
                       Email="cbissiker1@technorati.com",
                       FirstName="Carin",
                       LastName="Bissiker",Photo="" },
                new UserModel(){
                       UserId=3,
                       Email="jdeclerc2@techcrunch.com",
                       FirstName="Joelie",
                       LastName="de Clerc",Photo="" },
                new UserModel(){
                       UserId=4,
                       Email="cweond3@dedecms.com",
                       FirstName="Car",
                       LastName="Weond",Photo="" },
                new UserModel(){
                       UserId=5,
                       Email="twenden4@answers.com",
                       FirstName="Townie",
                       LastName="Wenden",Photo="" },
                new UserModel(){
                       UserId=6,
                       Email="cbrims5@g.co",
                       FirstName="Clementius",
                       LastName="Brims",Photo="" },
                new UserModel(){
                       UserId=7,
                       Email="vsheards6@vk.com",
                       FirstName="Valentine",
                       LastName="Sheards",Photo="" },
                new UserModel(){
                       UserId=8,
                       Email="tlias7@oracle.com",
                       FirstName="Tuesday",
                       LastName="Lias",Photo="" },
                new UserModel(){
                       UserId=9,
                       Email="aacheson8@ebay.co.uk",
                       FirstName="Ardra",
                       LastName="Acheson",Photo="" },
                new UserModel(){
                       UserId=10,
                       Email="sleyes9@blogspot.com",
                       FirstName="Shandie",
                       LastName="Leyes",Photo="" }

            };

            //Setup du service Categorie
            _catService.Setup(c => c.GetAll()).Returns
                (
                    new List<CategoryModel>()
                    {
                        new CategoryModel()
                        {
                             CategoryId = 1,
                              Label ="Développement Back-End",
                               Skills = AllSkills.Take(6)
                        },
                        new CategoryModel()
                        {
                             CategoryId = 2,
                              Label ="Développement Front-End",
                               Skills = AllSkills.Where(a=>new[]{1,4,5,6,7,8,9 }.Contains(a.SkillId))
                        },
                        new CategoryModel()
                        {
                             CategoryId = 3,
                              Label ="IOT",
                               Skills = new List<SkillModel>()
                        },
                        new CategoryModel()
                        {
                             CategoryId = 4,
                              Label ="Business Intelligence",
                             Skills = AllSkills.Where(a=>new[]{10,11}.Contains(a.SkillId))
                        },
                        new CategoryModel()
                        {
                             CategoryId = 5,
                              Label ="Big Data",
                               Skills = new List<SkillModel>()
                        },
                        new CategoryModel()
                        {
                             CategoryId = 6,
                              Label ="IA",
                               Skills = new List<SkillModel>()
                        },
                        new CategoryModel()
                        {
                             CategoryId = 7,
                              Label ="Bureautique",
                               Skills = AllSkills.Where(a=>new[]{12,13 }.Contains(a.SkillId))
                        },
                        new CategoryModel()
                        {
                             CategoryId = 8,
                              Label ="Analyse",
                               Skills = new List<SkillModel>()
                        },
                        new CategoryModel()
                        {
                             CategoryId = 8,
                              Label ="Sql Déclaratif",
                               Skills = new List<SkillModel>()
                        }
                    }
                ); ;

            //Setupe skill Service
            _skillService.Setup(s => s.GetAll()).Returns
                (
                    AllSkills
                );
            //Setup User Service
            _userService.Setup(u => u.GetAll()).Returns
                (
                    AllUsers
                );
        }

        [Test]
        public void Index()
        {

            // Arrange
    
            var controller = new HomeController(null, _catService.Object, _skillService.Object, _userService.Object);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result as ViewResult);
            Assert.IsAssignableFrom<HomeViewModel>((result as ViewResult).ViewData.Model);            

            Assert.Pass();
        }
    }
}