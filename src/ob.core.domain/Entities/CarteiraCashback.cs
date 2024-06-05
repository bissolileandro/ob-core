using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class CarteiraCashback : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal SaldoAtual { get; set; }
        public Boolean Ativo { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<CarteiraCashBackLancamentos> CarteiraCashBackLancamentos { get; set; }

    }
}
