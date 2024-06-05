using ob.core.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class CotacaoVeiculo : EntidadeBase
    {
        public int CotacaoId { get; set; }
        public string AnoModelo { get; set; }
        public string CepVeiculoPerNoite { get; set; }
        public DateTime? DataAplicacaoBlindagem { get; set; }
        public DateTime? DataAplicacaoKitGas { get; set; }
        public string MarcaVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string NumeroPlaca { get; set; }
        public bool PossuiBlindagem { get; set; }
        public bool PossuiKitGas { get; set; }
        public decimal? ValorAproximadoBlindagem { get; set; }
        public decimal? ValorAproximadoKitGas { get; set; }
        public bool VeiculoZeroKm { get; set; }
        public virtual Cotacao? Cotacao { get; set; }
    }
}
