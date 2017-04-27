using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POC.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> Get(Expression<Func<T, bool>> exp);
        T GetById(int id);
        bool Save(T o);
        void Delete(int id);
        void Delete(Expression<Func<T, bool>> exp);
    }
}
