using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.DAL.Entities
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public string Label { get; set; }


        public IEnumerable<SalaryUser> SalariesUser { get; set; }
    }
}
