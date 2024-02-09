using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;

namespace Entidades.Service.Service
{
    public class BeneficiarioService:IBeneficiarioService
    {
        private readonly IBeneficiarioRepository _beneficiarioRepository;

        public BeneficiarioService(IBeneficiarioRepository BeneficiarioRepository)
        {
            _beneficiarioRepository = BeneficiarioRepository;

        }

        public async Task<string> DeleteAsync(int BeneficiarioID)
        {
            return await _beneficiarioRepository.DeleteAsync(BeneficiarioID);
        }

        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostCadastrarAsync(BeneficiarioCommand command)
        {
            return await _beneficiarioRepository.PostCadastrarAsync(command);
        }

        public async Task<string> PutAtualizarAsync(int BeneficiarioID, BeneficiarioCommand command)
        {
            return await _beneficiarioRepository.PutAtualizarAsync(BeneficiarioID, command);
        }
    }
}


