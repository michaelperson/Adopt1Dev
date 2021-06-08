using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Label { get; set; }

        public IEnumerable<SkillModel> Skills { get; set; }
    }
}
