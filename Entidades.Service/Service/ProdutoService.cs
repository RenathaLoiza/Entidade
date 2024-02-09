using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;

namespace Entidades.Service.Service
{
    public class ProdutoService: IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;

        }
        public Task<string> DeleteAsync(int ProdutoID)
        {
            return _produtoRepository.DeleteAsync(ProdutoID);
        }

        public Task<string> GetActionAsync()
        {
            return _produtoRepository.GetActionAsync();
        }

        public async Task<string> PostCadastrarAsync(ProdutoCommand command)
        {
            return await _produtoRepository.PostCadastrarAsync(command);
        }

        public async Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            return await _produtoRepository.PutAtualizarAsync(ProdutoID, command);
        }
    }
}
 
