using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;
using ob.core.domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.application.Applications
{
    public class SistemaApplication : ApplicationBase<Sistema>, ISistemaApplication
    {
        public readonly ISistemaService sistemaService;
        public SistemaApplication(ISistemaService sistemaService)
            : base(sistemaService)
        {
            this.sistemaService = sistemaService;
        }

        public async Task<Sistema> GetByChave(Guid chave)
        {
            return await sistemaService.GetByChave(chave);
        }

        public async Task<Sistema> GetById(int id)
        {
            return await sistemaService.GetById(id);
        }
    }
}
