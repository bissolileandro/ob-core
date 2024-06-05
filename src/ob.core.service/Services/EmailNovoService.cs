using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using ob.core.domain.Interface.Services;
using System.Net;
using System.Net.Mail;

namespace ob.core.service.Services
{
    public class EmailNovoService : IEmailNovoService
    {
        private readonly IEmailConfiguracaoRepository emailConfiguracaoRepository;

        public EmailNovoService(IEmailConfiguracaoRepository emailConfiguracaoRepository)
        {
            this.emailConfiguracaoRepository = emailConfiguracaoRepository;
        }
        public async Task SendEmailAsync(EmailRequest mailRequest)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            var configuracaoEmail = await emailConfiguracaoRepository.ObterEmailConfiguracao();

            message.From = new MailAddress(configuracaoEmail.SmptEmail, "OneBroker");
            message.To.Add(new MailAddress(mailRequest.ToEmail));
            message.Subject = mailRequest.Subject;

            message.IsBodyHtml = true;
            message.Body = mailRequest.Body;
            smtp.Port = configuracaoEmail.SmptPorta;
            smtp.Host = configuracaoEmail.SmtpServidor;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(configuracaoEmail.SmptEmail, configuracaoEmail.SmptSenha);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            await smtp.SendMailAsync(message);
        }
    }

}
