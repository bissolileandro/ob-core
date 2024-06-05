using ob.core.domain.Entities;

namespace ob.core.domain.Interface.Services
{
    public interface IEmailNovoService
    {
        Task SendEmailAsync(EmailRequest emailRequest);
    }
}
