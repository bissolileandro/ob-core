using ob.core.domain.Entities;

namespace ob.core.domain.Interface.Services
{
    public interface IEmailService : IServiceBase<Email>
    {
        Task EnviarEmail(Email email);
    }
}
