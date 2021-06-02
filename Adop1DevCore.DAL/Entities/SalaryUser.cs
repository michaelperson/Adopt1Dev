using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adop1DevCore.DAL.Entities
{
    public class SalaryUser
    {
        public int UserId { get; set; }
        public int SalaryId { get; set; }
        public float Amount { get; set;}

        public virtual User User { get; set; }
        public virtual Salary Salary { get; set; }
    }
}
