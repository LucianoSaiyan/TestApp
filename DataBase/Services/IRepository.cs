using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Services
{
    public interface IRepository<T> where T : class 
    {
        Task<IQueryable<T>> GetAll();
        Task<T> Get(int id);
        Task<int> DeleteAsync(int id);
        Task<int> Update(int id, T element);
        Task<int> Add(T element);
    }
}
