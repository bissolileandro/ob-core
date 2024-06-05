using Microsoft.EntityFrameworkCore;
using ob.core.data.Context;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;

namespace ob.core.data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ObCoreContext context) 
            : base(context) 
        {
            
        }

        public async Task<bool> GetUsuarioPorEmail(string email)
        {
            try
            {
                return await db.Set<Usuario>().FirstOrDefaultAsync(w => w.Email == email) != null;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }

        public async Task<Usuario> GetUsuarioPorEmaileSenha(string email, string senha)
        {
            try
            {
                var usuario = await db.Set<Usuario>().FirstOrDefaultAsync(w => w.Email == email && w.Senha == senha);
                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }

        public async Task<bool> GetUsuarioPorCpf(string cpf)
        {
            try
            {
                return await db.Set<Usuario>().FirstOrDefaultAsync(w => w.CPFCNPJ == cpf) != null;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }

        public async Task<Usuario> ObterUsuarioPorEmail(string email)
        {
            try
            {
                return await db.Set<Usuario>().FirstOrDefaultAsync(w => w.Email == email);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }

        public async Task<Usuario> ObterUsuarioPorId(int id)
        {
            try
            {
                return await db.Set<Usuario>().FirstOrDefaultAsync(w => w.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }
    }
}
