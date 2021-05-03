using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DTO
{
   public class ClienteDTO
    {
        public int cod_cliente { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string telefone { get; set; }
        public string situacao { get; set; }



    }
}
