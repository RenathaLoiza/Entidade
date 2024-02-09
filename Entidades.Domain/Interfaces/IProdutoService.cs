using Entidades.Domain.Commands;

namespace Entidades.Domain.Interfaces
{
    public interface IProdutoService
    {
        Task<string> PostCadastrarAsync(ProdutoCommand command);
        Task<string> GetActionAsync();
        Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command);
        Task<string> DeleteAsync(int ProdutoID);
    }
}
