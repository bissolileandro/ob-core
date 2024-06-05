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
    public class SistemaController : ControllerBase
    {
        private readonly ISistemaApplication sistemaApplication;
        private readonly IMapper mapper;
        public SistemaController(ISistemaApplication sistemaApplication, IMapper mapper)
        {
            this.sistemaApplication = sistemaApplication;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var listaSistemas = mapper.Map<List<SistemaModel>>(await sistemaApplication.GetAllAsync());
                return Ok(listaSistemas);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }        

        [HttpPost]
        [Route("Inserir")]
        public async Task<IActionResult> Inserir([FromBody] SistemaModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entidade = await sistemaApplication.AddAsync(mapper.Map<Sistema>(model));
                    return Ok(mapper.Map<SistemaModel>(entidade));
                }
                else
                {
                    return BadRequest($"Modelo informado inválido!");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpPut]
        [Route("Atualizar")]
        public async Task<IActionResult> Atualizar([FromBody] SistemaModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entidade = await sistemaApplication.UpdateAsync(mapper.Map<Sistema>(model));

                    return Ok(mapper.Map<SistemaModel>(entidade));
                }
                else
                {
                    return BadRequest($"Id deve ser maior que 0!");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpDelete]
        [Route("Deletar")]
        public async Task<IActionResult> Deletar([FromBody] int id)
        {
            try
            {
                if (id > 0)
                {
                    var entidade = await sistemaApplication.GetById(id);
                    var retorno = await sistemaApplication.DeleteAnsync(entidade);
                    return Ok(mapper.Map<SistemaModel>(retorno));
                }
                else
                {
                    return BadRequest($"Id deve ser maior que 0!");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }
    }
}
