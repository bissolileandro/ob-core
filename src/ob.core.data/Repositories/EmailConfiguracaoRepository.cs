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
    public class EmailConfiguracaoRepository : RepositoryBase<EmailConfiguracao>, IEmailConfiguracaoRepository
    {
        public EmailConfiguracaoRepository(ObCoreContext context)
            : base(context)
        {

        }

        public async Task<EmailConfiguracao> ObterEmailConfiguracao()
        {
            try
            {
                var usuario = await db.Set<EmailConfiguracao>().FirstOrDefaultAsync();
                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }
    }
}
