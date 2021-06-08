using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.Models
{
    public class SkillModel
    {
        public int SkillId { get; set; }
        public string Label { get; set; }

        public IEnumerable<CategoryModel> Categories { get; set; } 
    }
}
