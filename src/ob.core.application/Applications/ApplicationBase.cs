using ob.core.domain.Interface.Application;
using ob.core.domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.application.Applications
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> serviceBase;
        public ApplicationBase(IServiceBase<TEntity> serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            serviceBase.Add(obj);
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            return await serviceBase.AddAsync(obj);
        }

        public async Task<TEntity> DeleteAnsync(TEntity obj)
        {
            return await serviceBase.DeleteAnsync(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return serviceBase.GetAll();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await serviceBase.GetAllAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity obj)
        {
            return await serviceBase.UpdateAsync(obj);

        }
    }
}
