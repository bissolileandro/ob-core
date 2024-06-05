using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class Sistema : EntidadeBase
    {
        public string Nome { get; set; }
        public Guid ChaveDeAcesso { get; set; }
        public string Token { get; set; }
        public bool Ativo { get; set; }
        public virtual List<ParametrosDeSistema> ParametrosDeSistemas { get; set; }
        public virtual List<FaqSistema> FaqSistemas { get; set; }
    }
}
