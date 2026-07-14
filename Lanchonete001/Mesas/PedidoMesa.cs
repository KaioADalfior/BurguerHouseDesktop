using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Pedido em aberto de uma mesa: os itens lançados, um eventual
    /// desconto e se já foi enviado para a cozinha/fila de pedidos.
    /// </summary>
    public class PedidoMesa
    {
        public List<ItemPedidoMesa> Itens { get; set; } = new List<ItemPedidoMesa>();
        public decimal Desconto { get; set; }
        public bool EnviadoParaCozinha { get; set; }

        public decimal Subtotal => Itens.Sum(i => i.Subtotal);

        /// <summary>Subtotal menos o desconto, nunca negativo.</summary>
        public decimal Total => Math.Max(0, Subtotal - Desconto);
    }
}