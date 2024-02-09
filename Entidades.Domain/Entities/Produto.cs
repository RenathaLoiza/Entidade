using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Domain.Entities
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string ProdutoNome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string QuantidadeDisponivelParaDoacao { get; set; }
        public string DoadorId { get; set; }
    }
}
