using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete001.Estoque
{
    public class Insumo
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal QuantidadeAtual { get; set; }
        public string Unidade { get; set; }
        public decimal QuantidadeMinima { get; set; }
        public decimal PrecoUnitario { get; set; }

        public bool EstoqueBaixo => QuantidadeAtual < QuantidadeMinima;
        public decimal ValorTotal => QuantidadeAtual * PrecoUnitario;
    }
}
