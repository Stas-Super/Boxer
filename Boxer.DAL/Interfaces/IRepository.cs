using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxer.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Delete(int id);
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Func<T, bool> predicate);
        Task Create(T item);
    }
}
