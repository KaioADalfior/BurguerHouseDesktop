using Lanchonete001.Estoque;

namespace Lanchonete001.Cardapio
{
    /// <summary>
    /// Um "ingrediente" da receita de um lanche/bebida: referencia um Insumo
    /// do estoque pelo nome e a quantidade consumida por unidade vendida.
    /// </summary>
    public class IngredienteReceita
    {
        public string NomeInsumo { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }

        /// <summary>Busca ao vivo o Insumo correspondente no estoque.</summary>
        public Insumo InsumoRelacionado => EstoqueRepositorio.BuscarPorNome(NomeInsumo);

        /// <summary>Custo desse ingrediente, calculado a partir do preço unitário atual do insumo.</summary>
        public decimal CustoItem
        {
            get
            {
                var insumo = InsumoRelacionado;
                return insumo != null ? insumo.PrecoUnitario * Quantidade : 0m;
            }
        }

        /// <summary>Indica se há estoque suficiente deste insumo para preparar uma unidade.</summary>
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