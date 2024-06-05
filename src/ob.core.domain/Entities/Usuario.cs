using ob.core.domain.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPFCNPJ { get; set; }
        public EnumTipoPessoaUsuario TipoPessoa { get; set; }
        public int PerfilUsuarioId { get; set; }
        public virtual PerfilUsuario PerfilUsuario { get; set; }
        public EnumTipoPlanoUsuário TipoDePlano { get; set; }
        public virtual CarteiraCashback? CarteiraCashback { get; set; }

        public Guid CodigoIndicacao { get; set; }
        public virtual IEnumerable<UsuarioGuardaChuva> UsuariosGuardaChuva { get; set; }
        public int LimiteIndicacao { get; set; }
        public string LinkRedefinirSennha { get; set; }


    }
}
