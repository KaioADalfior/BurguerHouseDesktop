using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Cardapio
{
    /// <summary>
    /// Um item vendável do cardápio (lanche ou bebida). O custo e a
    /// disponibilidade são sempre calculados a partir da receita
    /// (lista de insumos) e do estoque atual — nada fica "congelado".
    /// </summary>
    public class ItemCardapio
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoVenda { get; set; }
        public bool Ativo { get; set; } = true;
        public TipoItemCardapio Tipo { get; set; }
        public List<IngredienteReceita> Ingredientes { get; set; } = new List<IngredienteReceita>();

        /// <summary>Soma do custo de todos os insumos da receita.</summary>
        public decimal CustoEstimado => Ingredientes.Sum(i => i.CustoItem);

        /// <summary>Preço de venda menos o custo estimado.</summary>
        public decimal MargemLucro => PrecoVenda - CustoEstimado;

        /// <summary>Margem de lucro em percentual sobre o preço de venda.</summary>
        public decimal PercentualMargem => PrecoVenda > 0 ? (MargemLucro / PrecoVenda) * 100 : 0;

        /// <summary>
        /// Só está disponível para venda se estiver marcado como ativo e
        /// se houver estoque suficiente de TODOS os insumos da receita.
        /// </summary>
        public bool DisponivelParaVenda => Ativo && Ingredientes.Count > 0 && Ingredientes.All(i => i.DisponivelNoEstoque);
    }
}