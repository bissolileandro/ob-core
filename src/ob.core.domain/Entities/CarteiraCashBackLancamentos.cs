using ob.core.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class CarteiraCashBackLancamentos : EntidadeBase
    {
        public decimal Valor { get; set; }
        public decimal? ValorUtilizado { get; set; }
        public EnumTipoLancamento TipoLancamento { get; set; }
        public decimal Saldo { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public int CarteiraCashbackId { get; set; }
        public virtual CarteiraCashback CarteiraCashback { get; set; }
    }
}
