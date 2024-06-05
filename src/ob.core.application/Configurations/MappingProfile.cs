using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ob.core.application.Models;
using ob.core.domain.Entities;

namespace ob.core.application.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioModel>().ReverseMap();
            CreateMap<PerfilUsuario, PerfilUsuarioModel>().ReverseMap();
            CreateMap<Sistema, SistemaModel>().ReverseMap();
        }
    }
}
