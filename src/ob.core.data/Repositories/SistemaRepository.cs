using Microsoft.EntityFrameworkCore;
using ob.core.data.Context;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.data.Repositories
{
    public class SistemaRepository : RepositoryBase<Sistema>, ISistemaRepository
    {
        public SistemaRepository(ObCoreContext context)
            : base(context) 
        {
            
        }

        public async Task<Sistema> GetById(int id)
        {
            try
            {
                var sistema = await db.Set<Sistema>().FirstOrDefaultAsync(i => i.Id == id);

                return sistema;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao Obter Sistema: {e.Message}");
            }
        }

        public async Task<Sistema> GetByChave(Guid chave)
        {
            try
            {
                var sistema = await db.Set<Sistema>().FirstOrDefaultAsync(i => i.ChaveDeAcesso == chave && i.Ativo);

                return sistema;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao Obter Sistema: {e.Message}");
            }
        }
    }
}
