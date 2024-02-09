using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Entidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioService _beneficiarioService;

        public BeneficiarioController(IBeneficiarioService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> PostCadastrarAsync(BeneficiarioCommand command)
        {
            return Ok(await _beneficiarioService.PostCadastrarAsync(command));

        }
        [HttpGet]
        [Route("Read")]
        public async Task<IActionResult> GetActionAsync()
        {
            return Ok(await _beneficiarioService.GetActionAsync());
        }

        [HttpPut]
        [Route("Update")]

        public async Task<IActionResult> PutAtualizarAsync(int BeneficiarioID, BeneficiarioCommand command)
        {
            return Ok(await _beneficiarioService.PutAtualizarAsync(BeneficiarioID, command));


        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAsync(int BeneficiarioID)
        {
            return Ok(await _beneficiarioService.DeleteAsync(BeneficiarioID));
        }


    }

}


