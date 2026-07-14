using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Mesas
{
    public static class MesaRepositorio
    {
        public static List<Mesa> Mesas { get; } = new List<Mesa>();

        public static void DefinirQuantidade(int quantidade)
        {
            if (quantidade < 0) quantidade = 0;

            while (Mesas.Count > quantidade)
                Mesas.RemoveAt(Mesas.Count - 1);

            int proximoNumero = Mesas.Count > 0 ? Mesas.Max(m => m.Numero) + 1 : 1;
            while (Mesas.Count < quantidade)
            {
                Mesas.Add(new Mesa { Numero = proximoNumero });
                proximoNumero++;
            }
        }

        public static void GarantirPedidoAberto(Mesa mesa)
        {
            if (mesa.Pedido == null) mesa.Pedido = new PedidoMesa();
            if (mesa.Status == StatusMesa.Livre) mesa.Status = StatusMesa.Ocupada;
        }

        public static void FecharConta(Mesa mesa)
        {
            mesa.Pedido = null;
            mesa.Status = StatusMesa.Livre;
        }

        /// <summary>Envia o pedido da mesa para a fila do Kanban (UcPedidos).</summary>
        public static void EnviarParaCozinha(Mesa mesa)
        {
            if (mesa.Pedido == null || mesa.Pedido.Itens.Count == 0) return;

            mesa.Pedido.EnviadoParaCozinha = true;
            mesa.Pedido.StatusPreparo = StatusPreparoPedido.AguardandoPreparo;
        }

        /// <summary>Avança o pedido pra próxima coluna do Kanban.</summary>
        public static void AvancarStatusPreparo(PedidoMesa pedido)
        {
            switch (pedido.StatusPreparo)
            {
                case StatusPreparoPedido.AguardandoPreparo:
                    pedido.StatusPreparo = StatusPreparoPedido.EmPreparo;
                    break;
                case StatusPreparoPedido.EmPreparo:
                    pedido.StatusPreparo = StatusPreparoPedido.Entregue;
                    break;
                case StatusPreparoPedido.Entregue:
                    pedido.StatusPreparo = StatusPreparoPedido.Finalizado;
                    // pedido pronto e entregue: mesa fica "Fechando" (aguardando pagar a conta)
                    var mesa = Mesas.FirstOrDefault(m => m.Pedido == pedido);
                    if (mesa != null) mesa.Status = StatusMesa.Fechando;
                    break;
            }
        }
    }
}