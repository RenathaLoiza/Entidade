using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using System.Data.SqlClient;
using Dapper;

namespace Entidades.Repository.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        string banco = @"Server=(localdb)\mssqllocaldb;Database=CadastroBeneficiario;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> DeleteAsync(int BeneficiarioID)
        {
            string queryDeleteBeneficiario = "DELETE FROM Beneficiario WHERE BeneficiarioID=@BeneficiarioID";
            using (SqlConnection conn = new SqlConnection(banco))
            {
                await conn.ExecuteAsync(queryDeleteBeneficiario, new { BeneficiarioID = BeneficiarioID });
                return $"Exclusão do {queryDeleteBeneficiario} realizado com sucesso";
            }
        }

        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostCadastrarAsync(BeneficiarioCommand command)
        {
            string queryInsertBeneficiario = @" 
                                 insert into Beneficiario (Nome ,cidade ,estado,email,telefone ) 
                                 values (@Nome ,@cidade ,@estado,@email,@telefone ) ";

            using (SqlConnection conn = new SqlConnection(banco))
            {
                await conn.ExecuteAsync(queryInsertBeneficiario, new
                {
                    Nome = command.Nome,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    telefone = command.Telefone,


                });

                return "Cadastro realizado com sucesso";
            }
        }

        public async Task<string> PutAtualizarAsync(int BeneficiarioID, BeneficiarioCommand command)
        {
            string queryUpdateBeneficiario = "UPDATE Produto SET  (produtoNome ,descricao ,categoria,NomeDoDoador,QuantidadeDisponivelParaDoacao )" +
          "WHERE (@produtoNome ,@descricao ,@categoria,@NomeDoDoador,@QuantidadeDisponivelParaDoacao)";
            using (SqlConnection conn = new SqlConnection(banco))
            {

                conn.Execute(queryUpdateBeneficiario, new
                {
                    Nome = command.Nome,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone,

                });
                return "Atualização realizado com sucesso";

            }
        }
    }
}