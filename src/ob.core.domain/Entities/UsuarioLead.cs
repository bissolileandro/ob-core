using ob.core.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class UsuarioLead : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool UsuarioJaCadastrado { get; set; }
        public EnumTipoSeguro TipoSeguro { get; set; }
        public bool AceiteTermo { get; set; }
    }
}
