using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adop1DevCore.DAL.Entities
{
    public class Skill
    {
         public int SkillId { get; set; }
        public string Label { get; set; }

        public virtual IEnumerable<Category> Categories { get; set; }
        public virtual IEnumerable<SkillUser> SkillsUser { get; set; }
    }
}
