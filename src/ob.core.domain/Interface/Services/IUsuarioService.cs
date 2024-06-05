using ob.core.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Interface.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Task<bool> GetUsuarioPorEmail(string email);
        Task<Usuario> GetUsuarioPorEmaileSenha(string email, string senha);
        Task<bool> GetUsuarioPorCpf(string cpf);
        Task<Usuario> ObterUsuarioPorEmail(string email);
        Task<Usuario> ObterUsuarioPorId(int id);
    }
}
