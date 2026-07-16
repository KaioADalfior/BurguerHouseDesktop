using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Mesas
{
    public class PedidoMesa
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public List<ItemPedidoMesa> Itens { get; set; } = new List<ItemPedidoMesa>();
        public decimal Desconto { get; set; }
        public bool EnviadoParaCozinha { get; set; }
        public StatusPreparoPedido StatusPreparo { get; set; } = StatusPreparoPedido.AguardandoPreparo;

        /// <summary>Preenchida pelo FrmFecharConta no momento do pagamento.</summary>
        public FormaPagamento? FormaPagamento { get; set; }

        public decimal Subtotal => Itens.Sum(i => i.Subtotal);
        public decimal Total => Math.Max(0, Subtotal - Desconto);
    }
}