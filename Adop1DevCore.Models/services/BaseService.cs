using Adopte1DevCore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.Models.services
{
    public class BaseService
    {
        protected readonly DataContext _dc;

        public BaseService(DataContext dc)
        {
            _dc = dc;
        }
    }
}
