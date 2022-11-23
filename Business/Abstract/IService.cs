using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService<T>
    {
        Task<T> Create(T t);
        Task Delete(T t);
        Task<List<T>> GetAll();
        Task<T> GetElemanById(int id);
        Task<T> Update(T t);
    }
}
