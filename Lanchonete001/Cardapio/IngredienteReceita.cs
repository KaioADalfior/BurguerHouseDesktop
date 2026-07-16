using Lanchonete001.Estoque;

namespace Lanchonete001.Cardapio
{
    /// <summary>
    /// Um "ingrediente" da receita de um lanche/bebida: referencia um Insumo
    /// do estoque pelo Id (tabela ingredientes_receita) e a quantidade
    /// consumida por unidade vendida.
    /// </summary>
    public class IngredienteReceita
    {
        public int InsumoId { get; set; }
        public string NomeInsumo { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }

        /// <summary>Busca ao vivo o Insumo correspondente no estoque.</summary>
        public Insumo InsumoRelacionado => EstoqueRepositorio.BuscarPorId(InsumoId);

        public decimal CustoItem
        {
            get
            {
                var insumo = InsumoRelacionado;
                return insumo != null ? insumo.PrecoUnitario * Quantidade : 0m;
            }
        }

        public bool DisponivelNoEstoque
        {
            get
            {
                var insumo = InsumoRelacionado;
                return insumo != null && insumo.QuantidadeAtual >= Quantidade;
            }
        }
    }
}