namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Uma mesa do estabelecimento. Enquanto não tem pedido em aberto,
    /// fica "Livre"; ao lançar o primeiro item passa para "Ocupada".
    /// </summary>
    public class Mesa
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public StatusMesa Status { get; set; } = StatusMesa.Livre;
        public PedidoMesa Pedido { get; set; }

        public bool TemItens => Pedido != null && Pedido.Itens.Count > 0;
    }
}