using ob.core.domain.Entities;
using ob.core.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.application.Models
{
    public class UsuarioModel : BaseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPFCNPJ { get; set; }
        public EnumTipoPessoaUsuario TipoPessoa { get; set; }
        public int PerfilUsuarioId { get; set; }
        public virtual PerfilUsuarioModel PerfilUsuario { get; set; }
        public EnumTipoPlanoUsuário TipoDePlano { get; set; }
    }
}
