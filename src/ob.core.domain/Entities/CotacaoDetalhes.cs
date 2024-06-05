using ob.core.domain.Enums;

namespace ob.core.domain.Entities
{
    public class CotacaoDetalhes : EntidadeBase
    {
        public int CotacaoId { get; set; }
        public string CpfOuCnpj { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
        public bool MotoristaEntre18E15Anos { get; set; }
        public string NomeMotorista { get; set; }
        public bool PrincipalMotoristaVeiculo { get; set; }
        public virtual Cotacao? Cotacao { get; set; }
    }
}
