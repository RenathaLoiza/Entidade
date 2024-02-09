using Entidades.Domain.Commands;
using Entidades.Domain.Interfaces;
using System.Data.SqlClient;
using Dapper;

namespace Entidades.Repository.Repository
{
    public class DoadorRepository:IDoadorRepository
    {
        string banco = @"Server=(localdb)\mssqllocaldb;Database=CadastroDoador;Trusted_Connection=True;MultipleActiveResultSets=true";
        //deletar
        public async Task<string> DeleteAsync(int DoadorID)
        {
            string queryDeleteDoador = "DELETE FROM Doador WHERE DoadorID = @DoadorID";

            using (SqlConnection conn = new SqlConnection(banco))

                await conn.ExecuteAsync(queryDeleteDoador, new { DoadorID = DoadorID });

            return "Exclusão realizada com sucesso";
        }
        //ler
        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        //criar
        public async Task<string> PostCadastrarAsync(DoadorCommand command)
        {
            string queryInsertDoador = @"
            insert into Doador (DoadorNome,Cidade,Estado,Cep,Email,Telefone ) 
            values (@DoadorNome,@Cidade,@Estado,@Cep,@Email,@Telefone ) ";

            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryInsertDoador, new
                {
                    DoadorNome = command.DoadorNome,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone,

                });

                return "Cadastro realizado com sucesso";
            }
        }
        //update
        public async Task<string> PutAtualizarAsync(int DoadorID, DoadorCommand command)
        {
            string queryUpdateDoador = "UPDATE doador SET  (DoadorNome,Cidade,Estado,Cep,Email,Telefone )" +
                "WHERE (@DoadorNome,@Cidade,@Estado,@Cep,@Email,@Telefone )";
            using (SqlConnection conn = new SqlConnection(banco))
            {
                conn.Execute(queryUpdateDoador, new
                {
                    DoadorNome = command.DoadorNome,
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
    