using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    class Movimentacao
    {
        public DateTime data { get; set; }
        public int qtde { get; set; }
        public int tipo { get; set; }
    }
}
