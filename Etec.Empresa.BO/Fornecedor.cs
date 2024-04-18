using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.Empresa.BO
{
    class Fornecedor
    {
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Produto { get; set; } 
    }
}
