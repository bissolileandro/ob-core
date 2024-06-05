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
    public class PerfilUsuarioService : ServiceBase<PerfilUsuario>, IPerfilUsuarioService
    {
        private readonly IPerfilUsuarioRepository perfilUsuarioRepository;
        public PerfilUsuarioService(IPerfilUsuarioRepository perfilUsuarioRepository)
            : base(perfilUsuarioRepository) 
        {
            this.perfilUsuarioRepository = perfilUsuarioRepository;
        }
    }
}
