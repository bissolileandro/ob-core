using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Interface.Services
{
    public interface ISistemaService : IServiceBase<Sistema>
    {
        Task<Sistema> GetById(int id);
        Task<Sistema> GetByChave(Guid chave);
    }
}
