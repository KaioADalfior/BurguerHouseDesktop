namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Um item lançado no pedido de uma mesa (ex.: 2x X-Bacon). Referencia
    /// o item do cardápio pelo Id (itens_pedido.item_cardapio_id);
    /// NomeProduto é só um cache de exibição, vindo do JOIN com itens_cardapio.
    /// </summary>
    public class ItemPedidoMesa
    {
        public int Id { get; set; }
        public int ItemCardapioId { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; } = 1;

        public decimal Subtotal => PrecoUnitario * Quantidade;
    }
}