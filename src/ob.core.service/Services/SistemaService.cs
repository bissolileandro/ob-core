using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using ob.core.domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.service.Services
{
    public class SistemaService : ServiceBase<Sistema>, ISistemaService
    {
        public readonly ISistemaRepository sistemaRepository;

        public SistemaService(ISistemaRepository sistemaRepository)
            : base(sistemaRepository)
        {
            this.sistemaRepository = sistemaRepository;
        }

        public async Task<Sistema> GetByChave(Guid chave)
        {
            return await sistemaRepository.GetByChave(chave);
        }

        public async Task<Sistema> GetById(int id)
        {
            return await sistemaRepository.GetById(id);
        }
    }
}
