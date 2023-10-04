using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetOrdersById(Expression<Func<T, bool>> filter = null);
    }
}
