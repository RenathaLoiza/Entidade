using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;

namespace Entidades.Service.Service
{
    public class DoadorService: IDoadorService
    {
        private readonly IDoadorRepository _Repository;

        public DoadorService(IDoadorRepository repository)
        {
            _Repository = repository;
        }
        public async Task<string> DeleteAsync(int DoadorID)
        {
            return await _Repository.DeleteAsync(DoadorID);
        }

        public async Task<string> GetActionAsync()
        {
            return await _Repository.GetActionAsync();
        }

        public async Task<string> PostCadastrarAsync(DoadorCommand command)
        {

            return await _Repository.PostCadastrarAsync(command);
        }

        public async Task<string> PutAtualizarAsync(int DoadorID, DoadorCommand command)
        {

            return await _Repository.PutAtualizarAsync(DoadorID, command);
        }
    }
}
   