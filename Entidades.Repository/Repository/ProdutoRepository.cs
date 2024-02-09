using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using System.Data.SqlClient;
using Dapper;

namespace Entidades.Repository.Repository
{
    public class ProdutoRepository:IProdutoRepository
    {

        string banco = @"Server=(localdb)\mssqllocaldb;Database=CadastroDoador;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> DeleteAsync(int ProdutoID)
        {
            string queryDeleteProduto = "DELETE FROM Produto WHERE ProdutoID = @ProdutoID";
            using (SqlConnection conn = new SqlConnection(banco))

                await conn.ExecuteAsync(queryDeleteProduto, new { ProdutoID = ProdutoID });

            return "Exclusão realizada com sucesso";

        }
        //bucar algo
        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostCadastrarAsync(ProdutoCommand command)
        {
            string queryInsertDoador = @"
            insert into Produto (produtoNome ,descricao ,categoria,QuantidadeDisponivelParaDoacao,DoadorId ) 
            values (@produtoNome ,@descricao ,@categoria,@QuantidadeDisponivelParaDoacao,@DoadorId ) ";

            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryInsertDoador, new
                {
                    produtoNome = command.ProdutoNome,
                    descricao = command.Descricao,
                    categoria = command.Categoria,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,
                    DoadorId = command.DoadorId,


                });

                return "Cadastro realizado com sucesso";
            }
        }

        public async Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            string queryUpdateDoador = "UPDATE Produto SET  (produtoNome ,descricao ,categoria,QuantidadeDisponivelParaDoacao,DoadorId )" +
                 "WHERE (@produtoNome ,@descricao ,@categoria,@QuantidadeDisponivelParaDoacao,@DoadorId)";
            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryUpdateDoador, new
                {
                    produtoNome = command.ProdutoNome,
                    descricao = command.Descricao,
                    categoria = command.Categoria,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,
                    DoadorId = command.DoadorId,

                });
                return "Atualização realizado com sucesso";

            }
        }
    }
}
  
