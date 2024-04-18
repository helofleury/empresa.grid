using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.Empresa.BO
{
    public class Cliente
    {
       public string Nome  { get; set; }
       public string CPF { get; set; }
       public DateTime DtNascimento{ get; set; }
       public string Rua { get; set; }
       public int Numero { get; set; }
    }
}
