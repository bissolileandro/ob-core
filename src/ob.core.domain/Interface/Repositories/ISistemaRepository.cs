using ob.core.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Interface.Repositories
{
    public interface ISistemaRepository : IRepositoryBase<Sistema>
    {
        Task<Sistema> GetById(int id);
        Task<Sistema> GetByChave(Guid chave);
    }
}
