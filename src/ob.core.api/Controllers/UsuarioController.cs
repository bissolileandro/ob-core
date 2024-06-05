using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ob.core.application.Models;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Application;

namespace ob.core.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication usuarioApplication;
        private readonly IMapper mapper;
        public UsuarioController(IUsuarioApplication usuarioApplication, IMapper mapper)
        {
            this.usuarioApplication = usuarioApplication;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var listaUsuarios = mapper.Map<List<UsuarioModel>>(await usuarioApplication.GetAllAsync());                
                return Ok(listaUsuarios);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpGet]
        [Route("ValidarEmail/{email}")]
        [AllowAnonymous]
        public async Task<IActionResult> ValidarEmail([FromRoute]string email)
        {
            try
            {
                var emailCadastrado = await usuarioApplication.GetUsuarioPorEmail(email);
                return Ok(emailCadastrado);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpGet]
        [Route("ValidarCpf/{cpf}")]
        [AllowAnonymous]
        public async Task<IActionResult> ValidarCpf([FromRoute]string cpf)
        {
            try
            {
                var cpfCadastrado = await usuarioApplication.GetUsuarioPorCpf(cpf);
                return Ok(cpfCadastrado);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }
    }
}
