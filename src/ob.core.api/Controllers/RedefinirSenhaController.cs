using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ob.core.api.Service;
using ob.core.application.Models;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;
using System.Reflection;

namespace ob.core.api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class RedefinirSenhaController : ControllerBase
    {
        private readonly IUsuarioApplication usuarioApplication;
        private readonly IEmailApplication emailApplication;
        private readonly IMapper mapper;

        public RedefinirSenhaController(IMapper mapper, IEmailApplication emailApplication, IUsuarioApplication usuarioApplication)
        {
            this.usuarioApplication = usuarioApplication;
            this.emailApplication = emailApplication;
            this.mapper = mapper;

        }

        [HttpPost]
        [Route("RedefinirSenha")]
        public async Task<IActionResult> RedefinirSenha([FromBody] RedefinirSenhaModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await usuarioApplication.ObterUsuarioPorEmail(model.Email);
                    if (usuario is null)
                        return BadRequest(new { Mensagem = "Usuário não encontrado" });

                    object token = (usuario != null ? TokenService.GenerateTokenUsuario(mapper.Map<UsuarioModel>(usuario)) : null);

                    Type objType = token.GetType();
                    PropertyInfo propertyInfo = objType.GetProperty("token");

                    string tokenString = "";

                    if (propertyInfo != null)
                        tokenString = (string)propertyInfo.GetValue(token);

                    if (!string.IsNullOrEmpty(tokenString))
                    {
                        await usuarioApplication.SalvarRedefirSennha(usuario, tokenString.ToString());
                        await emailApplication.EnviarEmail(tokenString.ToString(), usuario);
                    }

                    return Ok(new { Mensagem = "Email enviado com sucesso!" });
                }
                else
                {
                    return BadRequest(new { Mensagem = $"Dados informados inválidos!" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { Mensagem = $"falha ao alterar senha do usuário: {e.Message}" });
            }
        }

        [HttpPost]
        [Route("AtualizarSenha")]
        [Authorize]
        public async Task<IActionResult> AtualizarSenha([FromBody] AtualizarSenhaUsuarioModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await usuarioApplication.ObterUsuarioPorEmail(model.Email);
                    if (usuario is null)
                        return BadRequest(new { Mensagem = "Usuário não encontrado" });

                    usuario.Senha = model.Senha;

                    await usuarioApplication.UpdateAsync(usuario);

                    return Ok(new { Mensagem = "Senha alterada com sucesso!" });
                }
                else
                {
                    return BadRequest(new { Mensagem = $"Dados informados inválidos!" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { Mensagem = $"falha ao atualizar senha do usuário: {e.Message}" });
            }
        }

        [HttpPost]
        [Route("obterusuarioportoken")]
        [Authorize]
        public async Task<IActionResult> AtualizarSenha([FromBody] TokenDeAcessoModel token)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var idUsuario = TokenService.ObterIdUsuario(token);

                    if(idUsuario <= 0)
                        return NotFound(new { Mensagem = $"Usuario não encontrado!" });

                    var usuario = await usuarioApplication.ObterUsuarioPorId(idUsuario);

                    return Ok(usuario);
                }
                else
                {
                    return BadRequest(new { Mensagem = $"Dados informados inválidos!" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { Mensagem = $"Falha ao obter usuário: {e.Message}" });
            }
        }
    }
}
