using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoEntity
{
    public class UsuarioEntity
    {
        public int UsuarioId { get; set; }
        public int NomeUsuario { get; set; }
        public bool Administrador { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
