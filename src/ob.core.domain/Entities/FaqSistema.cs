using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class FaqSistema : EntidadeBase
    {
        public int SistemaId { get; set; }
        public virtual Sistema Sistema { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
    }
}
