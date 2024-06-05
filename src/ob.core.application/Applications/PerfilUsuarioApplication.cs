using AutoMapper;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;
using ob.core.domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.application.Applications
{
    public class PerfilUsuarioApplication : ApplicationBase<PerfilUsuario>, IPerfilUsuarioApplication
    {
        private readonly IPerfilUsuarioService perfilUsuarioServie;
        private readonly IMapper mapper;
        public PerfilUsuarioApplication(IPerfilUsuarioService perfilUsuarioServie, IMapper mapper)
            :base(perfilUsuarioServie) 
        {
            this.perfilUsuarioServie = perfilUsuarioServie;
            this.mapper = mapper;
        }
    }
}
