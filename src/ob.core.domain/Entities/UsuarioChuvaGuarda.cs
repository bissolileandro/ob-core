using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class UsuarioGuardaChuva : EntidadeBase
    {
        public int UsuarioIndicacaoId { get; set; }

        public int UsuarioIndicadoId { get; set; }

        public int Nivel { get; set; }

        public int NivelIndicacao { get; set; }
        public virtual Usuario UsuarioIndicacao { get; set; }
    }
}
