using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoEntity
{
    public class VendaEntity
    {
        public int VendaId { get; set; }
        public int UsuarioId { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeProduto { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
