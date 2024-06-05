using ob.core.domain.Entities;

namespace ob.core.domain.Interface.Repositories
{
    public interface IEmailConfiguracaoRepository : IRepositoryBase<EmailConfiguracao>
    {
        Task<EmailConfiguracao> ObterEmailConfiguracao();
    }
}
