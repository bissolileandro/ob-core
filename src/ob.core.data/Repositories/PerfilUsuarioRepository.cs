using ob.core.data.Context;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.data.Repositories
{
    public class PerfilUsuarioRepository : RepositoryBase<PerfilUsuario>, IPerfilUsuarioRepository
    {
        public PerfilUsuarioRepository(ObCoreContext obCoreContext)
            :base(obCoreContext) 
        {
            
        }
    }
}
