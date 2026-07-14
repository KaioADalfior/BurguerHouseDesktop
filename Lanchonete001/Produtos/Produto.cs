namespace Lanchonete001.Produtos
{
    /// <summary>
    /// Um lanche/produto cadastrado no sistema, disponível para lançar
    /// em pedidos de mesa (FrmPedidoMesa) ou em outras telas de venda.
    /// </summary>
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        /// <summary>Ex.: "Lanches", "Bebidas", "Sobremesas" — opcional, usado para agrupar/filtrar.</summary>
        public string Categoria { get; set; }

        /// <summary>Produtos inativos não aparecem para seleção, mas continuam no histórico.</summary>
        public bool Ativo { get; set; } = true;

        /// <summary>
        /// Faz o ComboBox (DisplayMember = "Nome") e qualquer ToString()
        /// mostrarem algo legível sem precisar configurar mais nada.
        /// </summary>
        public override string ToString()
        {
            return Nome;
        }
    }
}