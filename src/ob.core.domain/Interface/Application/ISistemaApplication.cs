using ob.core.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Interface.Application
{
    public interface ISistemaApplication : IApplicationBase<Sistema>
    {
        Task<Sistema> GetById(int id);
        Task<Sistema> GetByChave(Guid chave);
    }
}
