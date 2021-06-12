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
    public class UserService : BaseService, IService<UserModel, User>
    {
        public UserService(DataContext dc) : base(dc)
        {

        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _dc.Users.Select(u=>new UserModel() 
            { 
                  Email = u.Email,
                  FirstName =u.FirstName,
                  LastName =u.LastName,
                  Photo =u.Photo,
                  UserId =u.UserId
            });
        }
        public IEnumerable<UserModel> GetFullAll()
        {
            List<UserModel> retour = new List<UserModel>();
            List<User> lu = _dc.Users.Include("SKillsUser").Include("SalariesUser").ToList();
            foreach (User u in lu)
            {
                List<Skill> ls = _dc.SkillsUser.Include("Skill").Where(s => s.UserId == u.UserId).Select(s=>s.Skill).ToList();
                retour.Add(new UserModel()
                {
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Photo = u.Photo,
                    UserId = u.UserId,
                    MinPrice = u.SalariesUser.OrderByDescending(ss=>ss.Amount).Take(1).Select(s => s.Amount).FirstOrDefault(),
                    Skills = ls.Select(s => new SkillModel() { Label = s.Label, SkillId = s.SkillId })
                });
            }
            return retour;
        }
        
        public IEnumerable<UserModel> GetAllBySkill(int skillId)
        {
            return _dc.Users
                .Include("SkillUser")
                .Where(sk=>sk.SKillsUser.Count(s=>s.SkillId==skillId)>0)
                .Select(u => new UserModel()
            {
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Photo = u.Photo,
                UserId = u.UserId
            });
        }

        public IEnumerable<UserModel> GetAllByCategory(int CategoryId)
        {
            return _dc.Users
                .Include("SkillUser")
                .Where(sk => sk.SKillsUser.Count(s => s.Skill.Categories.Where(c=>c.CategoryId == CategoryId).Count()>0 ) > 0)
                .Select(u => new UserModel()
                {
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Photo = u.Photo,
                    UserId = u.UserId
                });
        }

        
        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User form)
        {
            throw new NotImplementedException();
        }

        public void Update(User form)
        {
            throw new NotImplementedException();
        }
    }
}
