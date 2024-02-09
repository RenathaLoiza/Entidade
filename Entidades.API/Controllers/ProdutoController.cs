using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Entidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService ProdutoService)
        {
            _produtoService = ProdutoService;
        }
        [HttpPost]
        [Route("CadastrarProduto")]
        public async Task<IActionResult> PostCadastrarAsync(ProdutoCommand command)
        {
            return Ok(await _produtoService.PostCadastrarAsync(command));

        }
        [HttpGet]
        [Route("Read")]
        public async Task<IActionResult> GetActionAsync()
        {
            return Ok(await _produtoService.GetActionAsync());
        }

        [HttpPut]
        [Route("Update")]

        public async Task<IActionResult> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            return Ok(await _produtoService.PutAtualizarAsync(ProdutoID, command));


        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAsync(int ProdutoID)
        {
            return Ok(await _produtoService.DeleteAsync(ProdutoID));
        }
    }
}
    
