﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.Models
{
    public class UserModel
    {

        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }

        public float MinPrice { get; set; }

        public IEnumerable<SkillModel> Skills { get; set; }
    }
}
