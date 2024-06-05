using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Interface.Application
{
    public interface IApplicationBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> AddAsync(TEntity obj);
        Task<TEntity> DeleteAnsync(TEntity obj);
        Task<TEntity> UpdateAsync(TEntity obj);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
