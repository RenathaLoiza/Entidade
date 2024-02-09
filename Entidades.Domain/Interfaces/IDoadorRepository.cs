using Entidades.Domain.Commands;

namespace Entidades.Domain.Interfaces
{
    public interface IDoadorRepository
    {
        Task<string> PostCadastrarAsync(DoadorCommand command);
        Task<string> PutAtualizarAsync(int DoadorID, DoadorCommand command);
        Task<string> GetActionAsync();
        Task<string> DeleteAsync(int DoadorID);
    }
}
