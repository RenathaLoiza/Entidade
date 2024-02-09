namespace Entidades.Domain.Commands
{
    public class EntidadeCommand
    {
        public int EntidadeID { get; set; }
        public string Nome { get; set; }
        public long Cnpj { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long Cep { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public string NomeResponsavel { get; set; }
    }
}
