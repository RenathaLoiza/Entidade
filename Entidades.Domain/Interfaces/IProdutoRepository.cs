using Entidades.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<string> PostCadastrarAsync(ProdutoCommand command);
        Task<string> GetActionAsync();
        Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command);
        Task<string> DeleteAsync(int ProdutoID);
    }
}
