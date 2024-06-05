using ob.core.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ob.core.domain.Enums;

namespace ob.core.application.Models
{
    public class PerfilUsuarioModel : BaseModel
    {
        public string Descricao { get; set; }
        public EnumTipoUsuario TipoDeUsuario { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
    }
}
