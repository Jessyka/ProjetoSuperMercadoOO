using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoEntity
{
    public class ProdutoEntity
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public float PrecoProduto { get; set; }
        public int EstoqueProduto { get; set; }
    }
}
