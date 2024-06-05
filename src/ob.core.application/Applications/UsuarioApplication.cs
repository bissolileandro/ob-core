using AutoMapper;
using Microsoft.Extensions.Configuration;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;
using ob.core.domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.application.Applications
{
    public class UsuarioApplication : ApplicationBase<Usuario>, IUsuarioApplication
    {
        private readonly IUsuarioService usuarioService;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        public UsuarioApplication(IUsuarioService usuarioServie, IMapper mapper, IConfiguration configuration)
            : base(usuarioServie)
        {
            this.usuarioService = usuarioServie;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        public async Task<Usuario> GetUsuarioPorEmaileSenha(string email, string senha)
        {
            return await usuarioService.GetUsuarioPorEmaileSenha(email, senha);
        }

        public async Task<bool> GetUsuarioPorEmail(string email)
        {
            return await usuarioService.GetUsuarioPorEmail(email);
        }

        public async Task<bool> GetUsuarioPorCpf(string cpf)
        {
            return await usuarioService.GetUsuarioPorCpf(cpf);
        }

        public async Task<Usuario> ObterUsuarioPorEmail(string email)
        {
            return await usuarioService.ObterUsuarioPorEmail(email);
        }

        public async Task<Usuario> ObterUsuarioPorId(int id)
        {
            return await usuarioService.ObterUsuarioPorId(id);
        }

        public async Task<Usuario> SalvarRedefirSennha(Usuario usuario, string token)
        {
            try
            {
                usuario.LinkRedefinirSennha = ObterLik(token);
                return await UpdateAsync(usuario);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro: {e.Message}");
            }
        }

        private string ObterLik(string token)
        {
            var linkRedefinirSennha = configuration["LinkRedefinicaoSenha"];
            var longUrl = $"{linkRedefinirSennha}/redefinir-senha/{token}";

            using (var client = new HttpClient())
            {
                // Faça a solicitação GET para encurtar a URL
                var response = client.GetAsync($"http://tinyurl.com/api-create.php?url={Uri.EscapeUriString(longUrl)}").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Leia o conteúdo da resposta (link encurtado)
                    string shortUrl = response.Content.ReadAsStringAsync().Result;
                    return shortUrl;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
