using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ob.core.application.Applications;
using ob.core.application.Models;
using ob.core.domain.Interface.Application;

namespace ob.core.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PerfilUsuarioController : ControllerBase
    {
        private readonly IPerfilUsuarioApplication perfilUsuarioApplication;
        private readonly IMapper mapper;
        public PerfilUsuarioController(IPerfilUsuarioApplication perfilUsuarioApplication, IMapper mapper)
        {
            this.perfilUsuarioApplication = perfilUsuarioApplication;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var listaPerfins = mapper.Map<List<PerfilUsuarioModel>>(await perfilUsuarioApplication.GetAllAsync());
                return Ok(listaPerfins);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }
    }
}
