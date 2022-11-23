using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>

    {
        Task<T> Create(T t);

        Task Delete(T t);
        
        Task<List<T>> GetAll();
        
        Task<T> GetElemanById(int id);
        
        Task<T> Update(T t);

    }
}
