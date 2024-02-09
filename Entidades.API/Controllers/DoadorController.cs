using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Entidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;

        public DoadorController(IDoadorService doadorService)
        {
            _doadorService = doadorService;
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> PostCadastrarAsync(DoadorCommand command)
        {
            return Ok(await _doadorService.PostCadastrarAsync(command));

        }
        [HttpGet]
        [Route("Read")]
        public async Task<IActionResult> GetActionAsync()
        {
            return Ok(await _doadorService.GetActionAsync());
        }

        [HttpPut]
        [Route("Update")]

        public async Task<IActionResult> PutAtualizarAsync(int DoadorID, DoadorCommand command)
        {
            return Ok(await _doadorService.PutAtualizarAsync(DoadorID, command));


        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAsync(int DoadorID)
        {
            return Ok(await _doadorService.DeleteAsync(DoadorID));
        }




    }

}
    
