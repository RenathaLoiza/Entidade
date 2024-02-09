using Dapper;
using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using System.Data.SqlClient;

namespace Entidades.Repository.Repository
{
    public class EntidadeRepository : IEntidadeRepository
    {
        string banco = @"Server=(localdb)\mssqllocaldb;Database=CadastroDoador;Trusted_Connection=True;MultipleActiveResultSets=true";
        //deletar
        public async Task<string> DeleteAsync(int EntidadeID)
        {
            string queryDeleteEntidade = "DELETE FROM Doador WHERE DoadorID = @DoadorID";

            using (SqlConnection conn = new SqlConnection(banco))

                await conn.ExecuteAsync(queryDeleteEntidade, new { EntidadeID = EntidadeID });

            return "Exclusão realizada com sucesso";
        }
        //ler
        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        //criar
        public async Task<string> PostCadastrarAsync(EntidadeCommand command)
        {
            string queryInsertEntidade = @"
            insert into Doador (Nome,Cnpj,Cidade,Estado,Cep,Email,Telefone,NomeResponsavel) 
            values (@Nome,@Cnpj,@Cidade,@Estado,@Cep,@Email,@Telefone,@NomeResponsavel ) ";

            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryInsertEntidade, new
                {
                    Nome = command.Nome,
                    cnpj = command.Cnpj,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone,
                    NomeResponsavel = command.NomeResponsavel,

                });

                return "Cadastro realizado com sucesso";
            }
        }
        //update
        public async Task<string> PutAtualizarAsync(int EntidadeID, EntidadeCommand command)
        {
            string queryUpdateEntidade = "UPDATE doador SET  (Nome,Cnpj,Cidade,Estado,Cep,Email,Telefone,NomeResponsavel )" +
                "WHERE (@Nome,@Cnpj,@Cidade,@Estado,@Cep,@Email,@Telefone,@NomeResponsavel )";
            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryUpdateEntidade, new
                {
                    Nome = command.Nome,
                    Cnpj = command.Cnpj,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone,
                    NomeResponsavel= command.NomeResponsavel,

                });
                return "Atualização realizado com sucesso";

            }

        }
    }
}
    
