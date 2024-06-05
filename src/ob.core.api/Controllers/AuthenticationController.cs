using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ob.core.api.Service;
using ob.core.application.Models;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;

namespace ob.core.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUsuarioApplication usuarioApplication;
        private readonly ISistemaApplication sistemaApplication;
        private readonly IMapper mapper;

        public AuthenticationController(IMapper mapper, IUsuarioApplication usuarioApplication, ISistemaApplication sistemaApplication)
        {
            this.usuarioApplication = usuarioApplication;
            this.sistemaApplication = sistemaApplication;
            this.mapper = mapper;

        }

        [HttpPost]
        [Route("ObterTokenUsuario")]
        public async Task<IActionResult> ObterTokenUsuario([FromBody] UsuarioLoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = mapper.Map<UsuarioModel>(await usuarioApplication.GetUsuarioPorEmaileSenha(model.Email, model.Senha));

                    if (usuario is null)
                        return BadRequest("Email ou senha inválidos!");

                    var token = (usuario != null ? TokenService.GenerateTokenUsuario(usuario) : null);

                    return Ok(token);
                }
                else 
                {
                    return BadRequest($"Dados informados inválidos!");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"falha ao Obter o Token: {e.Message}");
            }
        }

        [HttpPost]
        [Route("ObterTokenSistema")]
        public async Task<IActionResult> ObterTokenSistema([FromBody] SistemaLoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sistema = mapper.Map<SistemaModel>(await sistemaApplication.GetByChave(model.ChaveDeAcesso));
                    var token = (sistema != null ? TokenService.GenerateTokenSistema(sistema) : null);

                    return Ok(token);
                }
                else
                {
                    return BadRequest($"Dados informados inválidos!");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"falha ao Obter o Token: {e.Message}");
            }
        }

        [HttpPost]
        [Route("ValidarToken")]
        public async Task<IActionResult> ValidarToken([FromBody] TokenDeAcessoModel tokenValido)
        {
            try
            {
                var tokenValidado = TokenService.ValidateToken(tokenValido);
                return Ok(tokenValidado);
                
            }
            catch (Exception e)
            {
                return BadRequest($"Falha ao validar o Token: {e.Message}");
            }
        }
    }
}
