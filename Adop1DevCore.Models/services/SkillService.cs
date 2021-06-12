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
    public class SkillService : BaseService, IService<SkillModel, Skill>
    {
        public SkillService(DataContext dc) : base(dc)
        {

        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SkillModel> GetAll()
        {
            return _dc.Skills.Select(s => new SkillModel()
            {
                SkillId = s.SkillId,
                Label = s.Label
            });
             
        }

        public Skill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Skill form)
        {
            throw new NotImplementedException();
        }

        public void Update(Skill form)
        {
            throw new NotImplementedException();
        }
    }
}
