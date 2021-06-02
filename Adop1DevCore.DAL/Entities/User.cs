using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adop1DevCore.DAL.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Password { get; set; }         
        public string Photo { get; set; }

        public IEnumerable<SalaryUser> SalariesUser { get; set; }
        public IEnumerable<SkillUser> SKillsUser { get; set; }
    }
}
