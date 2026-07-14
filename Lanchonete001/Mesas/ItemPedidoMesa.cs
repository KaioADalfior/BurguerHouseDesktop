namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Um item lançado no pedido de uma mesa (ex.: 2x X-Bacon).
    /// </summary>
    public class ItemPedidoMesa
    {
        public string NomeProduto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; } = 1;

        public decimal Subtotal => PrecoUnitario * Quantidade;
    }
}