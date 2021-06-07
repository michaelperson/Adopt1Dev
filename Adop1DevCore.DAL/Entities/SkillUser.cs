using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.DAL.Entities
{
    public class SkillUser
    {
        public int UserId { get; set;}
        public int SkillId { get; set; }

        public int Level { get; set; }

        public virtual User User { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
