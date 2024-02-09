using Entidades.Domain.Commands;

namespace Entidades.Domain.Interfaces
{
    public interface IEntidadeService
    {
        Task<string> PostCadastrarAsync(EntidadeCommand command);
        Task<string> GetActionAsync();
        Task<string> PutAtualizarAsync(int EntidadeID, EntidadeCommand command);
        Task<string> DeleteAsync(int EntidadeID);
    }
}
