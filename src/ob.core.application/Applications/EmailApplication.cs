using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;
using ob.core.domain.Interface.Services;
using System.Text;

namespace ob.core.application.Applications
{
    public class EmailApplication : ApplicationBase<Email>, IEmailApplication
    {
        private readonly IEmailService emailService;
        private readonly IEmailNovoService emailNovoService;

        public EmailApplication(IEmailService emailService, IEmailNovoService emailNovoService)
            : base(emailService)
        {
            this.emailService = emailService;
            this.emailNovoService = emailNovoService;
        }

        public async Task EnviarEmail(string token, Usuario usuario)
        {
            var htmlBory = ObterBody(usuario);
            var emailNovo = new EmailRequest
            {
                Subject = "Alteração de senha",
                Body = htmlBory.ToString(),
                ToEmail = usuario.Email
            };

            await emailNovoService.SendEmailAsync(emailNovo);
        }

        private StringBuilder ObterBody(Usuario usuario)
        {

            return new StringBuilder(@$"<html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Recuperação de Senha</title>
    <style>
        body {{
            font-family: Arial, sans-serif;
            background-color: transparent;
            margin: 0;
            padding: 0;
        }}
        .container {{
            max-width: 583px;
            max-height: 462px;
            margin: 100px auto;
            padding: 20px;
            background-color: #EAEAEA;
            border-radius: 31px;
            text-align: center;
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        }}
        p {{
            color: #133654;
        }}
    </style>
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;400;500;700;900&display=swap"" rel=""stylesheet"">
</head>
<body>
    <table class=""container"">
        <tr>
            <td>
                <img align='center' src='https://onebroker-home-dev.azurewebsites.net/assets/images/logo-one-broker-footer.png' alt='logo one broker' style='width: 234px; height: 74px;'>
            </td>
        </tr>
        <tr>
            <td>
                <p align=""left"" style=""color: #E44421;
                font-family: 'Roboto', sans-serif;
                margin: 22px 0 0 30px;
                font-size: 22px;
                font-style: normal;
                font-weight: 500;
                line-height: 34px; /* 154.545% */
                letter-spacing: 0.88px;"">Olá, <strong>{usuario.Nome}</strong></p>
            </td>
        </tr>
        <tr>
            <td>
                <p align=""left"" style=""color: #133654;
                margin: 25px 0 0 30px;
                width: 427px;
                font-family: 'Roboto', sans-serif;
                font-size: 18px;
                font-style: normal;
                font-weight: 500;
                line-height: 21px; /* 116.667% */
                letter-spacing: 0.72px;"">Recebemos uma solicitação de redefinição de senha. Para continuar clique no botão abaixo e crie uma nova senha.</p>
            </td>
        </tr>
        <tr>
            <td>
                <a align='center' style=""
                margin: 20px 0 0 0;
                display: inline-block;
                text-decoration: none;
                border: none;
                width: 200px;
                height: 25;
                padding: 10px 33px;
                justify-content: center;
                align-items: center;
                gap: 10px;
                flex-shrink: 0;
                border-radius: 20px;
                background: #E44421;
                color: #FFF;
                text-align: center;
                font-family: 'Roboto', sans-serif;
                font-size: 16px;
                font-style: normal;
                font-weight: 600;
                line-height: 26.5px; /* 165.625% */
                letter-spacing: 0.64px;"" href=""{usuario.LinkRedefinirSennha}"">REDEFINIR SENHA</a>
            </td>
        </tr>
        <tr>
            <td>
                <p align='left' style=""color: #133654;
                margin: 25px 0 0 30px;
                font-family: 'Roboto', sans-serif;
                font-size: 16px;
                font-style: normal;
                font-weight: 500;
                line-height: 21px; /* 131.25% */
                letter-spacing: 0.64px;"">ou copie esse link e cole no seu navegador:</p>
            </td>
        </tr>
        <tr>
            <td>
                <p align=""left"" style=""color: #133654;
                margin: 0 0 0 30px;
                font-family: 'Roboto', sans-serif;
                font-size: 16px;
                font-style: normal;
                font-weight: 500;
                line-height: 21px; /* 131.25% */
                letter-spacing: 0.64px;"">{usuario.LinkRedefinirSennha}</p>
            </td>
        </tr>
        <tr>
            <td>
                <p align=""left"" style=""color: #133654;
                width: 458px;
                margin: 13px 0 0 30px;
                font-family: 'Roboto', sans-serif;
                font-size: 14px;
                font-style: normal;
                font-weight: 500;
                line-height: 21px; /* 150% */
                letter-spacing: 0.56px;"">Esta solicitação é válida somente por 24 horas. Se você não fez esta solicitação, favor desconsiderar este e-mail e entrar em contato com a Central de Atendimento</p>
            </td>
        </tr>
    </table>
</body>
</html>");
        }
    }
}
