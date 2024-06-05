using ob.core.domain.Entities;

namespace ob.core.domain.Interface.Application
{
    public interface IUsuarioApplication : IApplicationBase<Usuario>
    {
        Task<Usuario> GetUsuarioPorEmaileSenha(string email, string senha);
        Task<bool> GetUsuarioPorEmail(string email);
        Task<bool> GetUsuarioPorCpf(string cpf);
        Task<Usuario> ObterUsuarioPorEmail(string email);
        Task<Usuario> ObterUsuarioPorId(int id);
        Task<Usuario> SalvarRedefirSennha(Usuario usuario, string token);
    }
}
