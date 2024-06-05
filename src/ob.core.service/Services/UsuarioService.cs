using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using ob.core.domain.Interface.Services;

namespace ob.core.service.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        public readonly IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository) 
        {
            this.usuarioRepository = usuarioRepository;
        }

        public async Task<bool> GetUsuarioPorEmail(string email)
        {
            return await usuarioRepository.GetUsuarioPorEmail(email);
        }

        public async Task<Usuario> GetUsuarioPorEmaileSenha(string email, string senha)
        {
            return await usuarioRepository.GetUsuarioPorEmaileSenha(email, senha);
        }

        public async Task<bool> GetUsuarioPorCpf(string cpf)
        {
            return await usuarioRepository.GetUsuarioPorCpf(cpf);
        }

        public async Task<Usuario> ObterUsuarioPorEmail(string email)
        {
            return await usuarioRepository.ObterUsuarioPorEmail(email);
        }

        public async Task<Usuario> ObterUsuarioPorId(int id)
        {
            return await usuarioRepository.ObterUsuarioPorId(id);
        }
    }
}
