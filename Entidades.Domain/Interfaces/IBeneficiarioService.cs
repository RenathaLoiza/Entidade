using Entidades.Domain.Commands;

namespace Entidades.Domain.Interfaces
{
    public interface IBeneficiarioService
    {
        Task<string> PostCadastrarAsync(BeneficiarioCommand command);
        Task<string> GetActionAsync();
        Task<string> PutAtualizarAsync(int BeneficiarioID, BeneficiarioCommand command);
        Task<string> DeleteAsync(int BeneficiarioID);
    }
}
