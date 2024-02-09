using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Entidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadeController : ControllerBase
    {
        private readonly IEntidadeService _entidadeService;

        public EntidadeController(IEntidadeService EntidadeService)
        {
            _entidadeService = EntidadeService;
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> PostCadastrarAsync(EntidadeCommand command)
        {
            return Ok(await _entidadeService.PostCadastrarAsync(command));

        }
        [HttpGet]
        [Route("Read")]
        public async Task<IActionResult> GetActionAsync()
        {
            return Ok(await _entidadeService.GetActionAsync());
        }

        [HttpPut]
        [Route("Update")]

        public async Task<IActionResult> PutAtualizarAsync(int EntidadeID, EntidadeCommand command)
        {
            return Ok(await _entidadeService.PutAtualizarAsync(EntidadeID, command));


        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAsync(int EntidadeID)
        {
            return Ok(await _entidadeService.DeleteAsync(EntidadeID));
        }




    }

}
    
