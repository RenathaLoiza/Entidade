using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;

namespace Entidades.Service.Service
{
    public class EntidadeService : IEntidadeService
    {
        private readonly IEntidadeRepository _Repository;
        
        public EntidadeService(IEntidadeRepository repository) 
        {
            _Repository = repository;
        
        }
        public async Task<string> DeleteAsync(int EntidadeID)
        {
            return await _Repository.DeleteAsync(EntidadeID);

        }

        public async Task<string> GetActionAsync()
        {
            return await _Repository.GetActionAsync();
        }

        public async Task<string> PostCadastrarAsync(EntidadeCommand command)
        {
            return await _Repository.PostCadastrarAsync(command);
        }

        public async Task<string> PutAtualizarAsync(int EntidadeID, EntidadeCommand command)
        {
            return await _Repository.PutAtualizarAsync(EntidadeID, command);
        }
    }
}
