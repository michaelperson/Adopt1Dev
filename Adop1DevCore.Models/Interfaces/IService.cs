using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1DevCore.Models.Interfaces
{
    public interface IService<T, U>
       where T : class
       where U : class
    {
        bool Delete(int id);
        IEnumerable<T> GetAll();
        U GetById(int id);
        void Insert(U form);
        void Update(U form);
    }
}
