using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;
using ob.core.domain.Interface.Services;
using System.Net;
using System.Net.Mail;

namespace ob.core.service.Services
{
    public class EmailService : ServiceBase<Email>, IEmailService
    {
        private readonly IEmailRepository emailRepository;
        private readonly IEmailConfiguracaoRepository emailConfiguracaoRepository;

        public EmailService(IEmailRepository emailRepository, IEmailConfiguracaoRepository emailConfiguracaoRepository)
            : base(emailRepository)
        {
            this.emailRepository = emailRepository;
            this.emailConfiguracaoRepository = emailConfiguracaoRepository;
        }

        public async Task EnviarEmail(Email email)
        {
            var configuracaoEmail = await emailConfiguracaoRepository.ObterEmailConfiguracao();

            try
            {
                using (var client = new SmtpClient(configuracaoEmail.SmtpServidor))
                {
                    client.Port = configuracaoEmail.SmptPorta;
                    client.Credentials = new NetworkCredential(configuracaoEmail.SmptEmail, configuracaoEmail.SmptSenha);
                    client.EnableSsl = false;

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(configuracaoEmail.SmptEmail),
                        Subject = email.Assunto,
                        Body = email.Corpo,
                        IsBodyHtml = true,
                    };

                    mailMessage.To.Add(email.Destinatario);

                    await client.SendMailAsync(mailMessage);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao enviar o e-mail.", ex);
            }

        }
    }
}
