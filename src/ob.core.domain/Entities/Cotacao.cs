using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class Cotacao : EntidadeBase
    {
        public virtual CotacaoVeiculo CotacaoVeiculo { get; set; }

        public virtual CotacaoDetalhes CotacaoDetalhes { get; }
    }
}
