using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Label { get; set; }

        public virtual IEnumerable<Skill> Skills { get; set; }
    }
}
